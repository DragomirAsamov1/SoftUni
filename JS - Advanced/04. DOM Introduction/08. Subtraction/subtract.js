function subtract() {
    let firstNum = Number(document.getElementById('firstNumber').value)
    let secNum = Number(document.getElementById('secondNumber').value)

    document.getElementById('result').textContent = firstNum - secNum
}