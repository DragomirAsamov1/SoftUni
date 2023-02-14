function solve() {
  let textElement = document.getElementById('text')
  let caseElement = document.getElementById('naming-convention')
  let resultElement = document.getElementById('result')

  let words = []
  let index

  words = textElement.value.toLowerCase().split(' ')

  switch (caseElement.value) {
    case '"Camel Case"':
      index = 1
      break;

    case '"Pascal Case"':
      index = 0
    break;
  
    default:
      resultElement.textContent = 'Error!'
      return
  }

  for (let i = index; i < words.length; i++) {
    let char = words[i][0]
    words[i] = words[i][0].toUpperCase() + words[i].substring(1, words[i].length)
  }
  
  resultElement.textContent = words.join('')
}