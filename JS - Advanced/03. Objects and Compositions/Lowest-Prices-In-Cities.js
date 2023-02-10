function solve(input){
    let register = []

    for (const iterator of input) {
        let [town, product, price] = iterator.split(' | ')
        price = Number(price)
        let tempReg = register.find(x => x.product == product)
        if(tempReg != undefined){
            if(price < tempReg.price){
                let index = register.findIndex(x => x.product == product)
                register.splice(index, 1, {town, product, price})
            }
        } else {
            register.push({town, product, price})
        }
    }

    for (const reg of register) {
        console.log(`${reg.product} -> ${reg.price} (${reg.town})`)
    }
}

solve(['Sample Town | Sample Product | 1000',
'Sample Town | Orange | 2',
'Sample Town | Peach | 1',
'Sofia | Orange | 1',
'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10']
)