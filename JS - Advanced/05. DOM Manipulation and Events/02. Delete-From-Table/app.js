function deleteByEmail() {
    let inputElement = document.getElementsByTagName('input')[0];
    let emailCellElements = document.querySelectorAll('tr td:nth-of-type(2)');

    let emailElements = Array.from(emailCellElements);
    let targetElement = emailElements.find(x => x.textContent == inputElement.value);

    let resultElement = document.getElementById('result');

    if(targetElement === undefined){
        resultElement.textContent = 'Not found.';
    } else {
        resultElement.textContent = 'Deleted.'
        targetElement.parentNode.remove();
    }

    inputElement.value = '';
}