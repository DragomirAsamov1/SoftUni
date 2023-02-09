function solve(arr){

    let magicSum = arr[0].reduce((x,y) => x + y)
    for (let i = 0; i < arr.length; i++) {
        let rowSum = arr[i].reduce((x,y) => x+y)
        let colSum = 0
        
        for (let j = 0; j < arr.length; j++) {
            colSum += arr[j][i]
        }
        
        if (magicSum != rowSum || magicSum != colSum) {
            return false
        }
    }

    return true
}

console.log(solve([[1, 0, 0],
    [0, 0, 1],
    [0, 1, 0]]   
   ))