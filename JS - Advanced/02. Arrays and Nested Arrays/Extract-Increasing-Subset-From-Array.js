function solve(arr){

    let outputArr = []
    outputArr[0] = arr[0]

    for (let i = 1; i < arr.length; i++) {
        if(outputArr[outputArr.length-1] <= arr[i]){
            outputArr.push(arr[i])
        }
    }

    return outputArr
}

console.log(solve([1, 3, 8, 4, 10, 12, 3, 2, 24]).join(', '))