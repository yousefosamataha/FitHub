"use strict";

// Class definition
var signUp = function () {
	// Variables
	var stepper;
	var form;
	var formSubmitButton;
	var formContinueButton;
	var stepperObj;
	var validations = [];
	var planPeriodMonthButton;
	var planPeriodAnnualButton;
	var CountriesList;

	// Handle Stepper
	var initStepper = function () {
		// Initialize Stepper
		stepperObj = new KTStepper(stepper);

		// Stepper change event
		stepperObj.on('kt.stepper.changed', function (stepper) {
			if (stepperObj.getCurrentStepIndex() === 4) {
				formSubmitButton.classList.remove('d-none');
				formSubmitButton.classList.add('d-inline-block');
				formContinueButton.classList.add('d-none');
			} else if (stepperObj.getCurrentStepIndex() === 5) {
				formSubmitButton.classList.add('d-none');
				formContinueButton.classList.add('d-none');
			} else {
				formSubmitButton.classList.remove('d-inline-block');
				formSubmitButton.classList.remove('d-none');
				formContinueButton.classList.remove('d-none');
			}
		});

		// Validation before going to next page
		stepperObj.on('kt.stepper.next', function (stepper) {
			console.log('stepper.next');

			// Validate form before change stepper step
			var validator = validations[stepper.getCurrentStepIndex() - 1]; // get validator for currnt step

			if (validator) {
				validator.validate().then(function (status) {
					console.log('validated!');

					if (status == 'Valid') {
						stepper.goNext();

						KTUtil.scrollTop();
					} else {
						KTUtil.scrollTop();
					}
				});
			} else {
				stepper.goNext();

				KTUtil.scrollTop();
			}
		});

		// Prev event
		stepperObj.on('kt.stepper.previous', function (stepper) {
			console.log('stepper.previous');

			stepper.goPrevious();
			KTUtil.scrollTop();
		});
	}
	var handleForm = function () {
		formSubmitButton.addEventListener('click', function (e) {
			// Validate form before change stepper step
			var validator = validations[2]; // get validator for last form

			validator.validate().then(function (status) {
				console.log('validated!');

				if (status == 'Valid') {
					// Prevent default button action
					e.preventDefault();
					form.submit();
				} else {
					KTUtil.scrollTop();
				}
			});
		});
	}
	var initValidation = function () {
		// Step 1
		validations.push(FormValidation.formValidation(
			form,
			{
				fields: {
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
		));

		// Step 2
		validations.push(FormValidation.formValidation(
			form,
			{
				fields: {
					'Input.GymDTO.Name': {
						validators: {
							notEmpty: {
								message: 'This Field Is Required!'
							}
						}
					},
					'Input.GymBranchDTO.CountryId': {
						validators: {
							notEmpty: {
								message: 'This Field Is Required!'
							}
						}
					},
					'Input.GymBranchDTO.Address': {
						validators: {
							notEmpty: {
								message: 'This Field Is Required!'
							}
						}
					},
					'Input.GymBranchDTO.Email': {
						validators: {
							notEmpty: {
								message: 'This Field Is Required!'
							},
							emailAddress: {
								message: 'The value is not a valid email address!'
							}
						}
					},
					'Input.GymBranchDTO.ContactNumber': {
						validators: {
							notEmpty: {
								message: 'This Field Is Required!'
							}
						}
					}
				},
				plugins: {
					trigger: new FormValidation.plugins.Trigger(),
					// Bootstrap Framework Integration
					bootstrap: new FormValidation.plugins.Bootstrap5({
						rowSelector: '.fv-row',
						eleInvalidClass: '',
						eleValidClass: ''
					})
				}
			}
		));

		// Step 3
		validations.push(FormValidation.formValidation(
			form,
			{
				fields: {
					'Input.GymUser.FirstName': {
						validators: {
							notEmpty: {
								message: 'This Field Is Required!'
							}
						}
					},
					'Input.GymUser.LastName': {
						validators: {
							notEmpty: {
								message: 'This Field Is Required!'
							}
						}
					},
					'Input.GymUser.BirthDate': {
						validators: {
							notEmpty: {
								message: 'This Field Is Required!'
							}
						}
					},
					'Input.GymUser.GenderId': {
						validators: {
							notEmpty: {
								message: 'This Field Is Required!'
							}
						}
					},
					'Input.Email': {
						validators: {
							notEmpty: {
								message: 'This Field Is Required!'
							},
							emailAddress: {
								message: 'The value is not a valid email address!'
							}
						}
					},
					'Input.Password': {
						validators: {
							notEmpty: {
								message: 'This Field Is Required!'
							}
						}
					},
					'Input.ConfirmPassword': {
						validators: {
							notEmpty: {
								message: 'This Field Is Required!'
							},
							identical: {
								compare: function () {
									return form.querySelector('[name="Input.Password"]').value;
								},
								message: 'The password and its confirm are not the same'
							}
						}
					}
				},
				plugins: {
					trigger: new FormValidation.plugins.Trigger(),
					// Bootstrap Framework Integration
					bootstrap: new FormValidation.plugins.Bootstrap5({
						rowSelector: '.fv-row',
						eleInvalidClass: '',
						eleValidClass: ''
					})
				}
			}
		));
	}

	// Handle Plan Period Selection
	var handlePlanPeriodSelection = function () {
		// Handle period change
		planPeriodMonthButton.addEventListener('click', function (e) {
			e.preventDefault();

			planPeriodMonthButton.classList.add('active');
			planPeriodAnnualButton.classList.remove('active');

			changePlanPrices('month');
		});

		planPeriodAnnualButton.addEventListener('click', function (e) {
			e.preventDefault();

			planPeriodMonthButton.classList.remove('active');
			planPeriodAnnualButton.classList.add('active');

			changePlanPrices('annual');
		});
	}
	var changePlanPrices = function (type) {
		var items = document.querySelectorAll('[data-kt-plan-price-month]');
		var subscriptionTypeInputField = document.querySelector('#SubscriptionTypeId');

		if (type === 'month') {
			subscriptionTypeInputField.value = 1;
		} else if (type === 'annual') {
			subscriptionTypeInputField.value = 2;
		}

		items.forEach(function (item) {
			var monthPrice = item.getAttribute('data-kt-plan-price-month');
			var annualPrice = item.getAttribute('data-kt-plan-price-annual');

			if (type === 'month') {
				item.innerHTML = monthPrice;
			} else if (type === 'annual') {
				item.innerHTML = annualPrice;
			}
		});
	}

	// Handle Select Country
	var handleSelectCountry = () => {
		// Format options
		var optionFormat = function (item) {
			if (!item.id) {
				return item.text;
			}

			var span = document.createElement('span');
			var template = '';

			template += '<img src="' + item.element.getAttribute('data-country-flag') + '" class="rounded-circle me-2" style="height:19px;" alt="image"/>';
			template += item.text;

			span.innerHTML = template;

			return $(span);
		}

		// Init Select2
		$('#SelectCountry').select2({
			minimumResultsForSearch: Infinity,
			templateSelection: optionFormat,
			templateResult: optionFormat
		});
	}

	var changeCountry = () => {
		document.getElementById('SelectCountry').onchange = function () {
			var selectedValueId = document.getElementById('SelectCountry').value;
			var selectedValueObj = CountriesList.filter(c => c.id == selectedValueId)[0];
			$("#SelectCountryCurrency").select2("val", selectedValueId);
			$("#SelectCountryTimeZone").select2("val", selectedValueId);
			document.querySelector("#BranchContactNumber").innerText = selectedValueObj.callingCode;
		};
	}

	// Get Countries List
	var getCountriesList = () => {
		$.ajax({
			url: '/Home/GetCountriesList',
			type: 'GET',
			success: function (data) {
				CountriesList = data;
			}
		});
	}

	// Handle Selected Subscription Query String
	var handleSelectedSubscriptionQueryString = () => {
		const urlParams = new URLSearchParams(window.location.search);
		const planId = urlParams.get('planId');
		const subscriptionTypeId = urlParams.get('subscriptionTypeId');
		var inputRadioList = document.querySelectorAll('[type="radio"]');

		if (planId != null) {
			inputRadioList.forEach(r => {
				if (r.value == planId) {
					r.closest("label").click();
					formContinueButton.click();
				}
			});
		}

		subscriptionTypeId == 1 ? planPeriodMonthButton.click() : subscriptionTypeId == 2 ? planPeriodAnnualButton.click() : planPeriodMonthButton.click();
	}

	return {
		// Public Functions
		init: function () {
			stepper = document.querySelector('#kt_create_account_stepper');

			if (!stepper) {
				return;
			}

			form = stepper.querySelector('#registerForm');
			// form = stepper.querySelector('#kt_create_account_form');
			formSubmitButton = stepper.querySelector('[data-kt-stepper-action="submit"]');
			formContinueButton = stepper.querySelector('[data-kt-stepper-action="next"]');
			planPeriodMonthButton = stepper.querySelector('[data-kt-plan="month"]');
			planPeriodAnnualButton = stepper.querySelector('[data-kt-plan="annual"]');

			// Handlers
			initStepper();
			initValidation();
			handleForm();
			handlePlanPeriodSelection();
			handleSelectCountry();
			changeCountry();
			getCountriesList();
			handleSelectedSubscriptionQueryString();
		}
	};
}();

// On document ready
KTUtil.onDOMContentLoaded(function () {
	signUp.init();
});