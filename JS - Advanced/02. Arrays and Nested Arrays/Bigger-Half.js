function solve(arr){
    arr.sort(function (a,b){return a-b})

    let startIndex = Math.ceil(arr.length / 2)

    if(arr.length % 2 == 1){
        startIndex -= 1
    }
    return arr.slice(startIndex)
}

solve([4, 7, 2, 5])
solve([3, 19, 14, 7, 2, 19, 6])