let usernameElement = document.getElementById("username");
let passwordElement = document.getElementById("password");
let confirmPasswordElement = document.getElementById("confirm-password");
let emailElement = document.getElementById("email");
let checkedCompanyElement = document.getElementById("company");
let companyInfoElement = document.getElementById("companyInfo");
let validElement = document.getElementById("valid");

checkedCompanyElement.addEventListener("click", isCompanyCheck);

let submitButton = document.getElementById("submit");
submitButton.addEventListener("click", validate);

const usernameRegex = /^[a-z0-9]{3,20}$/gim;
const passwordRegex = /^[\w]{5,15}$/gim;
const emailRegex = /^[^@.]+@[^@]*\.[^@]*$/;

function isCompanyCheck() {
  if (checkedCompanyElement.checked) {
    companyInfoElement.style.display = "block";
  } else {
    companyInfoElement.style.display = "none";
  }
}

function validate() {
  let isValid = true;

  if (!usernameRegex.test(usernameElement.value)) {
    usernameElement.style.borderColor = "red";
    isValid = false;
  }

  if (!passwordRegex.test(passwordElement.value)) {
    passwordElement.style.borderColor = "red";
    isValid = false;
  }

  if (passwordElement.value != confirmPasswordElement.value) {
    confirmPasswordElement.style.borderColor = "red";
    isValid = false;
  }

  if (!emailRegex.test(emailElement.value)) {
    emailElement.style.borderColor = "red";
    isValid = false;
  }

  if (checkedCompanyElement.checked) {
    let companyNumber = document.getElementById("companyNumber");
    if (companyNumber.value < 1000 || companyNumber.value > 9999) {
      companyInfoElement.style.borderColor = "red";
      isValid = false;
    } else {
      companyInfoElement.style.border = "none";
    }
  }

  if (isValid) {
    validElement.style.display = "block";
  }
}
