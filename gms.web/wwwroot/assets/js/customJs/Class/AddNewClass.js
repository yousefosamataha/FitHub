﻿"use strict";
import { globalClass } from './custom.js';

// Class definition
var addNewClass = function () {
    // Shared variables
    const form = document.getElementById('add_new_class_form');
    // const selectClassesInputElm = document.querySelector('#SelectedClasses');
    var currentLanguage = globalClass.checkLanguage(".AspNetCore.Culture").split("=").slice(-1)[0];
    //const hostName = window.location.origin;
    //var classesList = [
    //    { value: 1, name: 'Yoga Class' },
    //    { value: 2, name: 'Aerobics Class' },
    //    { value: 3, name: 'Hit Class' },
    //    { value: 4, name: 'Cardio Class' },
    //    { value: 5, name: 'Pilates' },
    //    { value: 6, name: 'Zumba Class' },
    //    { value: 7, name: 'Power Yoga Class' },
    //];
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
                    'ClassName': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'SelectedStaffId': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'SelectedLocationId': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'BookingFees': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'StartTime': {
                        validators: {
                            notEmpty: {
                                message: data.thisfieldisrequired
                            }
                        }
                    },
                    'EndTime': {
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

    // Membership Classes Selection
    //function tagTemplate(tagData) {
    //    return `
    //    <tag title="${tagData.name}" contenteditable='false' spellcheck='false' tabIndex="-1" class="${this.settings.classNames.tag}" ${this.getAttributes(tagData)}>
    //        <x title='' class='tagify__tag__removeBtn' role='button' aria-label='remove tag'></x>
    //        <div class="d-flex align-items-center">
    //            <span class='tagify__tag-text'>${tagData.name}</span>
    //        </div>
    //    </tag>`
    //}
    //function suggestionItemTemplate(tagData) {
    //    return `
    //    <div ${this.getAttributes(tagData)} class='tagify__dropdown__item' tabindex="0" role="option">
    //    ${tagData.name}
    //    </div>`
    //}

    //var tagify = new Tagify(selectClassesInputElm, {
    //    whitelist: classesList,
    //    dropdown: {
    //        closeOnSelect: false,
    //        enabled: 0,
    //        maxItems: 20,
    //        classname: 'tagify__inline__suggestions',
    //        searchKeys: ['name']
    //    },
    //    templates: {
    //        tag: tagTemplate,
    //        dropdownItem: suggestionItemTemplate
    //    }
    //})

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
                        // form.submit();
                        var data = {};
                        data.MembershipStatusId = $('[name="MembershipStatusId"]').val();
                        data.MembershipName = $('[name="MembershipName"]').val();
                        data.MembershipDuration = $('[name="MembershipDuration"]').val();
                        data.MembershipDurationTypeId = $('[name="MembershipDurationTypeId"]').val();
                        data.MembershipDescription = $('[name="MembershipDescription"]').val();
                        data.ClassIsLimit = $('[name="ClassIsLimit"][checked="checked"]').val();
                        data.ClassLimitDays = $('[name="ClassLimitDays"]').val();
                        data.ClassLimitationId = $('[name="ClassLimitationId"]').val();
                        data.SelectedClasses = tagify.value;
                        data.MembershipAmount = $('[name="MembershipAmount"]').val();
                        data.SignupFee = $('[name="SignupFee"]').val();

                        $.ajax({
                            url: '/Membership/AddNewMembership',
                            type: 'POST',
                            data: {
                                model: data
                            },
                            // dataType: "json",
                            // contentType: "application/json; charset=utf-8;",
                            success: function (response) {
                                //toastr.success("Membership Added successfully!");
                                //toastr.success("تمت إضافة العضوية بنجاح!");
                                window.location.href = `/Membership/MembershipsList`;
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

    return {
        init: function () {
            //handleMembershipStatus();
            //handleClassLimitation();
            //formSubmition();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    addNewClass.init();
});