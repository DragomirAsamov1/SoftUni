function solve (arr){
    let orderedArray = []
    arr.forEach(element => {
        if(element < 0){
            orderedArray.unshift(element)
        } else {
            orderedArray.push(element)
        }
    })

    console.log(orderedArray.join('\n'))
}
