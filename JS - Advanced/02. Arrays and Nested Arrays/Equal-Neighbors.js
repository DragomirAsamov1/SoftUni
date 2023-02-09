function solve(arr){
    let equalsCount = 0

    for (let i = 0; i < arr.length - 1; i++) {
        for (let j = 0; j < arr.length; j++) {
            if (arr[i][j] == arr[i+1][j]) {
                equalsCount++
            }
        }
    }

    for (let i = 0; i < arr.length; i++) {
        for (let j = 0; j < arr.length - 1; j++) {
            if (arr[i][j] == arr[i][j + 1]) {
                equalsCount++
            }
        }
        
    }

    return equalsCount
}

console.log(solve([['2', '3', '4', '7', '0'],
['4', '0', '5', '3', '4'],
['2', '3', '5', '4', '2'],
['9', '8', '7', '5', '4']]
))