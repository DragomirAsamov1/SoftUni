function solve(arr){

    let matrix = arr.map(row => row.split(' ').map(Number))
    let firstSum = 0
    let secSum = 0

    for (let i = 0; i < matrix.length; i++) {

        firstSum += matrix[i][i]
        secSum += matrix[i][matrix.length - i - 1]
    }

    if(firstSum == secSum){
        for (let i = 0; i < matrix.length; i++) {
            for (let j = 0; j < matrix.length; j++) {
                if (i != j && i != matrix.length - 1 - j) {
                    matrix[i][j] = firstSum
                }
                
            }
        }
    }
    
    for (let i = 0; i < arr.length; i++) {
        console.log(matrix[i].join(' '))
    }
}

solve(['5 3 12 3 1',
'11 4 23 2 5',
'101 12 3 21 10',
'1 4 5 2 2',
'5 22 33 11 1']
)