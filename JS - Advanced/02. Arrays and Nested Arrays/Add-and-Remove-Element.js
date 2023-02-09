function solve(arr){
    let index = 0
    let outputArr = []
    
    for (let i = 0; i < arr.length; i++) {
        switch (arr[i]) {
            case 'add':
                outputArr[index] = i + 1
                index++
                break
            case 'remove':
                outputArr.pop()
                index--
                break
        
            default:
                break;
        }
    }

    if (outputArr.length == 0) {
        console.log('Empty')
    } else {
        console.log(outputArr.join('\n'))
    }
}

solve(['remove', 
'remove', 
'remove']

)