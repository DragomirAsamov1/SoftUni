function solve() {
    let inputElement = document.getElementById('input')
    let textArr = inputElement.value.split('.').filter(s => s !== '')
    let resultDiv = document.getElementById('output')

    while(textArr.length > 0){

      let p = document.createElement('p')
      p.textContent = textArr.splice(0, 3).join('. ') + '.'

      resultDiv.appendChild(p)

    }

}