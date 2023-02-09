function solve(arr, element){
    let outputarr = []
    let index = 0
    for (let i = 0; i < arr.length; i+= element) {
        outputarr[index] = arr[i]
        index++
    }

    return outputarr
}

console.log(solve(['5', 
'20', 
'31', 
'4', 
'20'], 
2
))

