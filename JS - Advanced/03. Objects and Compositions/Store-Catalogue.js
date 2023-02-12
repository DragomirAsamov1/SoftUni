function solve(input){
    input.sort()

    let dictionary = []

    for (let i = 0; i < input.length; i++) {
        let letter = input[i][0]
        
        if (!dictionary.includes(letter)){
            dictionary.push(letter)
        }
    }

    dictionary.forEach(letter => {
        console.log(letter)
        input.forEach(element => {
            let [product, price] = element.split(' : ')
            if (product[0] == letter){
                console.log(`  ${product}: ${price}`)
            }
        })
    });
}

solve(['Appricot : 20.4',
'Fridge : 1500',
'TV : 1499',
'Deodorant : 10',
'Boiler : 300',
'Apple : 1.25',
'Anti-Bug Spray : 15',
'T-Shirt : 10']
)