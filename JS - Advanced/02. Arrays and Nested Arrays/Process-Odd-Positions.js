function solve(arr){
    let resultArr = []
    for (let i = 1; i < arr.length; i+=2) {
        resultArr.splice(0, 0, arr[i] * 2)
    }

    return resultArr.join(' ')
}

console.log(solve([10, 15, 20, 25]))
console.log(solve([3, 0, 10, 4, 7, 3]))