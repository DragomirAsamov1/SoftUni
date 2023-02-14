function search() {
   let listElements = document.getElementsByTagName('li')
   let searchedElement = document.getElementById('searchText').value
   let resultElement = document.getElementById('result')

   let matches = 0

   for (let i = 0; i < listElements.length; i++) {
      if(listElements[i].textContent.includes(searchedElement) && searchedElement != ''){
         matches++
         listElements[i].style.fontWeight = 'bold'
         listElements[i].style.textDecoration = 'underline'
      } else {
         listElements[i].style.fontWeight = 'normal'
         listElements[i].style.textDecoration = 'none'
      }
   }

   resultElement.textContent = matches
}
