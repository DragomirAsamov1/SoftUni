function toggle() {
    let button = document.getElementsByClassName('button')[0]

    let textElement = document.getElementById('extra')

    if(button.textContent == 'More'){
        textElement.style.display = 'block'
        button.textContent = 'Less'
    } else if(button.textContent == 'Less'){
        textElement.style.display = 'none'
        button.textContent = 'More'
    }
}