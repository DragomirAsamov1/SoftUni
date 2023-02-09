function solve (input){
    if(input === undefined){
        input = 5
    }

    for (let i = 0; i < input; i++) {
        let outputString = ''
        for (let j = 0; j < input - 1; j++) {
            outputString += '* '
        }
        outputString += '*'
        console.log(outputString)
    }
}

solve()