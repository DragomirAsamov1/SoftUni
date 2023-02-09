function output (param1, param2, param3){
    let parameter1 = param1.length
    let parameter2 = param2.length
    let parameter3 = param3.length

    let sumLength = parameter1 + parameter2 + parameter3

    let averageSum = Math.floor(sumLength / 3)

    console.log(sumLength);
    console.log(averageSum);
}

output('pasta', '5', '22.3')