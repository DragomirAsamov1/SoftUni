function sumTable() {
    let costElements = document.querySelectorAll('tr td:nth-of-type(2)')

    let resultElement = document.getElementById('sum')
    resultElement.textContent = Array.from(costElements).reduce((a,b) => {
        let currentValue = Number(b.textContent) || 0;

        return a + currentValue
    }, 0)
}