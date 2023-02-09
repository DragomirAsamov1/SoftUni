function solve(arr){
    let smallestArr = arr.slice().sort((a,b) => a - b)

    arr.sort((a,b) => b - a)

    let resultArr = []

    for (let i = 0; i < Math.floor(arr.length / 2); i++) {
        resultArr.push(smallestArr[i])
        resultArr.push(arr[i])
    }

    console.log(resultArr.join(', '))
}

solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56])