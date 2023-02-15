function addItem() {
    let itemsElement = document.getElementById('items');
    let newULElement = document.createElement('li');
    let inputElement = document.getElementById('newItemText');
    newULElement.textContent = inputElement.value;
    inputElement.value = '';
    itemsElement.appendChild(newULElement);
}