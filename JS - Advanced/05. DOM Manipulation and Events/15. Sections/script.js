function create(words) {
   let parentElement = document.getElementById('content');

   for(let i = 0; i < words.length; i++){
    let div = document.createElement('div');
    let p = document.createElement('p');
    let text = document.createTextNode(words[i]);

    p.appendChild(text);
    p.style.display = 'none';
    div.appendChild(p);
    div.addEventListener('click', onSelect);
    parentElement.appendChild(div);
   };

   function onSelect(event){
    event.target.children[0].style.display = 'block';
   }
}