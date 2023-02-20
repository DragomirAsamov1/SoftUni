function solve() {
   let textArea = document.querySelector('body > div > textarea');
   let totalPrice = 0;
   let listOfUniqueThings = [];
   let addbtnArr = Array.from(document.getElementsByClassName('add-product'));

   for(let i = 0; i < addbtnArr.length; i++){
      addbtnArr[i].addEventListener('click', function one(){
         let name = document.querySelector(`body > div > div:nth-child(${i+2}) > div.product-details > div`).textContent;
         let price = document.querySelector(`body > div > div:nth-child(${i+2}) > div.product-line-price`).textContent;

         if(!listOfUniqueThings.includes(name)){
            listOfUniqueThings.push(name);
         }

         totalPrice += Number(price);
         textArea.value += `Added ${name} for ${price} to the cart.\n`;
      })
   }

   let checkout = document.getElementsByClassName('checkout')[0];
   checkout.addEventListener('click', function final(){
      let finalString = `You bought ${listOfUniqueThings.join(', ')} for ${totalPrice.toFixed(2)}.`;
      textArea.value += finalString;
      disableButtons();
   });

   function disableButtons(){
      let buttons = Array.from(document.querySelectorAll('button'));
      buttons.forEach(x => x.disabled = true)
   }
   
}