"use strict";
import { globalClass } from '../custom.js';

// Class definition
var editMembership = function () {
    // Shared variables
    const form = document.getElementById('edit_membership_form');
    const selectClassesInputElm = document.querySelector('#select_classes');
    var currentLanguage = globalClass.checkLanguage(".AspNetCore.Culture").split("=").slice(-1)[0];
    const hostName = window.location.origin;
    var classesList = [
        { value: 1, name: 'Yoga Class' },
        { value: 2, name: 'Aerobics Class' },
        { value: 3, name: 'Hit Class' },
        { value: 4, name: 'Cardio Class' },
        { value: 5, name: 'Pilates' },
        { value: 6, name: 'Zumba Class' },
        { value: 7, name: 'Power Yoga Class' },
    ];
    var jsonlocalizerData = () => {
        return $.ajax({
            url: '/Home/GetJsonlocalizer',
            type: 'GET',
            data: { culture: currentLanguage },
            dataType: 'json'
        });
    }
    var validator;

    // Handle Validation With Jsonlocalizer
    jsonlocalizerData().then(data => {
        validator = FormValidation.formValidation(form,
            {
                fields: {
                    'MembershipName': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'MembershipDuration': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'MembershipDurationTypeId': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'MembershipAmount': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'SignupFee': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    }
                },
                plugins: {
                    trigger: new FormValidation.plugins.Trigger(),
                    bootstrap: new FormValidation.plugins.Bootstrap5({
                        rowSelector: '.fv-row',
                        eleInvalidClass: '',
                        eleValidClass: ''
                    })
                }
            }
        );
    });

    // Membership Status Handler
    const handleMembershipStatus = () => {
        const target = document.getElementById('membership_status');
        const select = document.getElementById('MembershipStatusId');
        const statusClasses = ['bg-success', 'bg-danger'];

        $(select).on('change', function (e) {
            const value = e.target.value;
            switch (value) {
                case '1': {
                    target.classList.remove(...statusClasses);
                    target.classList.add('bg-success');
                    break;
                }
                case '2': {
                    target.classList.remove(...statusClasses);
                    target.classList.add('bg-danger');
                    break;
                }
            }
        });
    }

    // Membership Class Limitation
    const handleClassLimitation = () => {
        const allConditions = document.querySelectorAll('[name="ClassIsLimit"][type="radio"]');
        const conditionMatch = document.querySelector('[data-kt-ecommerce-catalog-add-category="auto-options"]');

        allConditions.forEach(radio => {
            radio.addEventListener('change', e => {
                allConditions.forEach(ele => $(ele).removeAttr("checked"));
                $(e.target).attr("checked", "checked");
                if (e.target.value === "true") {
                    conditionMatch.classList.remove('d-none');
                    jsonlocalizerData().then(data => {
                        validator.addField("ClassLimitDays", {
                            validators: {
                                notEmpty: {
                                    message: data.thisfieldisrequired
                                }
                            }
                        });
                        validator.addField("ClassLimitationId", {
                            validators: {
                                notEmpty: {
                                    message: data.thisfieldisrequired
                                }
                            }
                        });
                    });
                } else {
                    conditionMatch.classList.add('d-none');
                    $('[name="ClassLimitDays"]').val(null);
                    $('[name="ClassLimitationId"]').val(null).trigger('change');
                    validator.removeField("ClassLimitDays");
                    validator.removeField("ClassLimitationId");
                }
            });
        })
    }

    // Membership Classes Selection
    function tagTemplate(tagData) {
        return `
        <tag title="${tagData.name}" contenteditable='false' spellcheck='false' tabIndex="-1" class="${this.settings.classNames.tag}" ${this.getAttributes(tagData)}>
            <x title='' class='tagify__tag__removeBtn' role='button' aria-label='remove tag'></x>
            <div class="d-flex align-items-center">
                <span class='tagify__tag-text'>${tagData.name}</span>
            </div>
        </tag>`
    }
    function suggestionItemTemplate(tagData) {
        return `
        <div ${this.getAttributes(tagData)} class='tagify__dropdown__item' tabindex="0" role="option">
        ${tagData.name}
        </div>`
    }

    var tagify = new Tagify(selectClassesInputElm, {
        whitelist: classesList,
        dropdown: {
            closeOnSelect: false,
            enabled: 0,
            maxItems: 20,
            classname: 'tagify__inline__suggestions',
            searchKeys: ['name']
        },
        templates: {
            tag: tagTemplate,
            dropdownItem: suggestionItemTemplate
        }
    })

    // Add New Membership Form Submition
    const formSubmition = () => {
        const submitButton = document.getElementById('add_new_membership_form_submit');
        submitButton.addEventListener('click', function (e) {
            // Prevent default button action
            e.preventDefault();

            // Validate form before submit
            if (validator) {
                validator.validate().then(function (status) {
                    if (status == 'Valid') {
                        var data = {};
                        data.Id = $('[name="Id"]').val();
                        data.BranchId = $('[name="BranchId"]').val();
                        data.MembershipStatusId = $('[name="MembershipStatusId"]').val();
                        data.MembershipName = $('[name="MembershipName"]').val();
                        data.MembershipDuration = $('[name="MembershipDuration"]').val();
                        data.MembershipDurationTypeId = $('[name="MembershipDurationTypeId"]').val();
                        data.MembershipDescription = $('[name="MembershipDescription"]').val();
                        data.ClassIsLimit = $('[name="ClassIsLimit"][checked="checked"]').val();
                        data.ClassLimitDays = $('[name="ClassLimitDays"]').val();
                        data.ClassLimitationId = $('[name="ClassLimitationId"]').val();
                        // data.SelectedClasses = tagify.value;
                        data.MembershipAmount = $('[name="MembershipAmount"]').val();
                        data.SignupFee = $('[name="SignupFee"]').val();

                        $.ajax({
                            url: '/Membership/UpdateMembershipPlan',
                            type: 'POST',
                            data: {
                                modelDTO: data
                            },
                            success: function (response) {
                                console.log(response);
                                // window.location.href = `/Membership/MembershipsList`;
                            },
                            error: function (xhr, status, error) {
                                console.error('Error:', error);
                            }
                        });
                    }
                });
            }
        });
    }

    // Handle On Edit Change
    const handleOnEditChange = () => {
        $("#MembershipStatusId").change();
        const conditionMatch = document.querySelector('[data-kt-ecommerce-catalog-add-category="auto-options"]');
        var value = $('[name="ClassIsLimit"][checked="checked"]').val();
        if (value === "true") {
            conditionMatch.classList.remove('d-none');
        } else {
            conditionMatch.classList.add('d-none');
        }
    }

    return {
        init: function () {
            handleMembershipStatus();
            handleClassLimitation();
            formSubmition();
            handleOnEditChange();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    editMembership.init();
});