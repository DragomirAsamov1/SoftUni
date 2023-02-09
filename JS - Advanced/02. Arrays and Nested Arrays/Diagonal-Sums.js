function solve(arr){
    let firstSum = 0
    let finalSum = 0

    for (let i = 0; i < arr.length; i++) {
            firstSum += arr[i][i]
    }

    for (let i = 0; i < arr.length; i++) {
        finalSum += arr[i][arr.length - i - 1]
    }

    return firstSum + " " + finalSum
}

console.log(solve([[3, 5, 17],
    [-1, 7, 14],
    [1, -8, 89]]   
   ))