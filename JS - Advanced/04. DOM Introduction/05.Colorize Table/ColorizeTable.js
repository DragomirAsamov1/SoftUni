function colorize() {
    let tableElements = document.getElementsByTagName('tr')

    for (let i = 1; i < tableElements.length; i+=2) {
        tableElements[i].style.backgroundColor = 'Teal'
    }
}