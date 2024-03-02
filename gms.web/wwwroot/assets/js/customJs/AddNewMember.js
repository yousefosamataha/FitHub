"use strict";
import { globalClass } from './custom.js';

// Class definition
var addNewMember = function () {
    // Shared variables
    const addNewMemberForm = document.getElementById('add_new_member_form');
    const selectClassesInputElm = document.querySelector('#select_classes');
    var currentLanguage = globalClass.checkLanguage(".AspNetCore.Culture").split("=").slice(-1)[0];
    var datatableLanguage = currentLanguage == "ar-EG" ? "ar" : currentLanguage == "fr-FR" ? "fr" : "en";
    var validator = FormValidation.formValidation(addNewMemberForm,
        {
            fields: {
                'FirstName': {
                    validators: {
                        notEmpty: {
                            message: 'This Field Is Required!'
                        }
                    }
                },
                'LastName': {
                    validators: {
                        notEmpty: {
                            message: 'This Field Is Required!'
                        }
                    }
                },
                'Birthdate': {
                    validators: {
                        notEmpty: {
                            message: 'This Field Is Required!'
                        }
                    }
                },
                'Gender': {
                    validators: {
                        notEmpty: {
                            message: 'This Field Is Required!'
                        }
                    }
                },
                'Email': {
                    validators: {
                        notEmpty: {
                            message: 'This Field Is Required!'
                        }
                    }
                },
                'Mobile': {
                    validators: {
                        notEmpty: {
                            message: 'This Field Is Required!'
                        }
                    }
                },
                'State': {
                    validators: {
                        notEmpty: {
                            message: 'This Field Is Required!'
                        }
                    }
                },
                'City': {
                    validators: {
                        notEmpty: {
                            message: 'This Field Is Required!'
                        }
                    }
                },
                'Address': {
                    validators: {
                        notEmpty: {
                            message: 'This Field Is Required!'
                        }
                    }
                },
                'Username': {
                    validators: {
                        notEmpty: {
                            message: 'This Field Is Required!'
                        }
                    }
                },
                'Password': {
                    validators: {
                        notEmpty: {
                            message: 'This Field Is Required!'
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
    var birthDateFlatpickr;
    const groupsList = [
        { value: 1, name: 'Aerobics', image: 'https://img.freepik.com/free-vector/running-abstract-concept-vector-illustration-sports-lifestyle-daily-workout-training-exercise-speed-race-morning-jogging-outdoor-stadium-marathon-athlete-track-activity-abstract-metaphor_335657-4260.jpg?t=st=1709327762~exp=1709331362~hmac=2684bd0d55a82e65a4e8fb1c0fb117d77a883367a257a0a83d80c3312e9211b4&w=740' },
        { value: 2, name: 'Body Building', image: 'https://img.freepik.com/free-vector/protein-shake-illustration_23-2150017421.jpg?t=st=1709327868~exp=1709331468~hmac=18aca94170607f4193f4f9ea73c87c091d84e0eab82932fc9f7bbd84dc74e98c&w=740' },
        { value: 3, name: 'General Training', image: '' },
        { value: 4, name: 'Weight Gain', image: '' },
        { value: 5, name: 'Weight Loss', image: '' },
        { value: 6, name: 'Yoga', image: '' }
    ];

    // Init Birth Date Flatpickr
    var initFlatpickr = () => {
        const birthDateElement = document.querySelector('#birthdate_date_picker');

        $(birthDateElement).flatpickr({
            locale: globalClass.flatpickrLanguage,
            dateFormat: "Y-m-d",
            altFormat: "d/m/Y",
        });
    }

    // Member Status Handler
    const handleMemberStatus = () => {
        const target = document.getElementById('member_tatus');
        const select = document.getElementById('member_status_select');
        const statusClasses = ['bg-success', 'bg-danger'];

        $(select).on('change', function (e) {
            const value = e.target.value;

            switch (value) {
                case "Active": {
                    target.classList.remove(...statusClasses);
                    target.classList.add('bg-success');
                    break;
                }
                case "Inactive": {
                    target.classList.remove(...statusClasses);
                    target.classList.add('bg-danger');
                    break;
                }
            }
        });
    }

    // Member Group Selection
    function tagTemplate(tagData) {
        return `
        <tag title="${tagData.name}" contenteditable='false' spellcheck='false' tabIndex="-1" class="${this.settings.classNames.tag}" ${this.getAttributes(tagData)}>
            <x title='' class='tagify__tag__removeBtn' role='button' aria-label='remove tag'></x>
            <div class="d-flex align-items-center">
                ${tagData.image.length > 0 ?
                    `<img class="rounded-circle w-30px h-30px me-2" src="${tagData.image}">` :
                    `<span class='rounded-circle w-30px h-30px me-2 symbol-label' style="display: block;background-size: cover;background-position: center;"></span>`
                }
                <span class='tagify__tag-text'>${tagData.name}</span>
            </div>
        </tag>`
    }
    function suggestionItemTemplate(tagData) {
        return `
        <div ${this.getAttributes(tagData)} class='tagify__dropdown__item d-flex align-items-center' tabindex="0"  role="option">
            ${tagData.image.length > 0 ?
                `<img class="rounded-circle w-30px h-30px me-2" src="${tagData.image}">` :
                `<span class='rounded-circle w-30px h-30px me-2 symbol-label' style="display: block;background-size: cover;background-position: center;"></span>`
            }
            <div class="d-flex flex-column">
                <strong>${tagData.name}</strong>
            </div>
        </div>`
    }

    var tagify = new Tagify(selectClassesInputElm, {
        //tagTextProp: 'name',
        //enforceWhitelist: true,
        dropdown: {
            closeOnSelect: false,
            enabled: 0,
            classname: '',
            searchKeys: ['name']
        },
        templates: {
            tag: tagTemplate,
            dropdownItem: suggestionItemTemplate
        },
        whitelist: groupsList
    })

    // Add New Membership Form Submition
    const formSubmition = () => {
        const submitButton = document.getElementById('add_new_member_form_submit');
        submitButton.addEventListener('click', function (e) {
            // Prevent default button action
            e.preventDefault();

            // Validate form before submit
            if (validator) {
                validator.validate().then(function (status) {
                    if (status == 'Valid') {
                        // Show loading indication and Disable button to avoid multiple click
                        submitButton.setAttribute('data-kt-indicator', 'on');
                        submitButton.disabled = true;

                        // Simulate form submission.
                        setTimeout(function () {
                            // Remove loading indication
                            submitButton.removeAttribute('data-kt-indicator');

                            // Enable button
                            submitButton.disabled = false;

                            // Show popup confirmation
                            Swal.fire({
                                text: "Form has been successfully submitted!",
                                icon: "success",
                                buttonsStyling: false,
                                confirmButtonText: "Ok, got it!",
                                customClass: {
                                    confirmButton: "btn btn-primary"
                                }
                            });

                            //form.submit(); // Submit form
                        }, 2000);
                    }
                });
            }
        });
    }

    return {
        init: function () {
            initFlatpickr();
            handleMemberStatus();
            formSubmition();
        }
    };
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
    addNewMember.init();
});

//${
//    tagData.avatar.length > 0 ?
//    `<img onerror="this.style.visibility='hidden'" class="rounded-circle w-40px me-2" src="assets/media/${tagData.avatar}">` :
//    `<span class='rounded-circle w-40px h-40px me-2 symbol-label' style="display: block;background-size: cover;"></span>`
//}