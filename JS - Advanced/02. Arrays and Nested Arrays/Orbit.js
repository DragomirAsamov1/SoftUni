function solve(arr){
    let matrix = [[]]

    for (let i = 0; i < arr[1]; i++) {
        matrix[i] = new Array(arr[0])
    }

    matrix[arr[2]][arr[3]] = 1

    
}

solve([4,4,0,0])