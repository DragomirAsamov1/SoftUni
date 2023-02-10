function solve(array){
    let numArr = []
    let symbolArr = []

    array.forEach(element => {        
        if(typeof(element) == 'number'){
            numArr.push(element)
        } else {
            symbolArr.push(element)
        }
    });

    if(numArr.length < 2){
        console.log('Error: not enough operands!')
        return
    }

    if(numArr.length != symbolArr.length + 1){
        console.log('Error: too many operands!')
        return
    }

    while(numArr.length > 1){
        let almostLastNum = numArr[numArr.length - 2]
        let lastNum = numArr[numArr.length - 1]

        let result

        switch (symbolArr[0]){
            case '+': result = almostLastNum + lastNum
            break;
            case '-': result = almostLastNum - lastNum
            break;
            case '*': result = almostLastNum * lastNum
            break;
            case '/': result = parseInt(almostLastNum / lastNum)
            break;
        }
        symbolArr.shift()
        numArr.splice(numArr.length - 2, 2)
        numArr.push(result)
    }

    console.log(numArr[0])
}

solve([15,
    '/']      
   )