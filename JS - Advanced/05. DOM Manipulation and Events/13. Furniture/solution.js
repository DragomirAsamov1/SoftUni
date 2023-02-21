function solve() {
  let inputText = document.querySelectorAll('textarea');
  document.querySelector('button').addEventListener('click', sendText(inputText[0].value));
  let tableBody = document.getElementsByTagName('tbody')[0];
  let buttons = document.getElementsByTagName('button');

  buttons[0].addEventListener('click', sendText());

  function sendText(){
    let json = JSON.parse(document.getElementsByTagName('textarea')[0].value);

    for(const furniture of json){
      let row = doucment.createElement('tr');

      let image = document.createElement('td');
      image.innerHTML = `<img src = "${furniture.img}">`;
      row.appendChild(image);

      createNewElement(furniture)

      let nameTable = document.createElement('td');
      let p = document.createElement('p');
      p.textContent = furniture.name;
      nameTable.appendChild(p);
      row.appendChild(nameTable);

      let priceTable = document.createElement('td');
      let p1 = document.createElement('p');
      p1.textContent = furniture.price;
      priceTable.appendChild(p1);
      row.appendChild(priceTable);

      let decorationFactor = document.createElement('td');
      let p2 = document.createElement('p');
      p2.textContent = furniture.decFactor;
      decorationFactor.appendChild(p2);
      row.appendChild(decorationFactor);

      let checkBox = document.createElement('td');
      let chB = document.createElement('input');
      chB.setAttribute('type', 'checkBox');
      row.appendChild(checkBox);

      tableBody.appendChild(row);
    }
  }

  let checkedFurniture = [];
  let totalPrice = 0;
  let decorationFactor = 0;
  let count = 0;

  buttons[1].addEventListener('click', processFurnitures());


  function processFurnitures(){
    let trElements = Array.from(document.getElementsByTagName('tr'));
    for(let i = 2; i < trElements.length; i++){
      if(trElements[i].children[4].children[0].checked){
        checkedFurniture.push(trElements[i].children[1].textContent);
        totalPrice += Number(trElements[i].children[2].textContent);
        decorationFactor += Number(trElements[i].children[3].textContent);
      };
      count++;
    };

    inputText[1].value += `Bought furniture: ${checkedFurniture.join(', ')}\nTotal price: ${totalPrice.toFixed(2)}\nAverage decoration factor: ${decorationFactor / count}`;
  };

}