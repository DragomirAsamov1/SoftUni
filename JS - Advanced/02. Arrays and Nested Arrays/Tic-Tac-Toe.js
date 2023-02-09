function solve(arr){
    let matrix = []
    const allEqual = arr => arr.every(v => v === arr[0])

    let mark
    let turn = -1

    for (let i = 0; i < 3; i++) {
    matrix.push(['false', 'false' ,'false'])
    }

    for (let i = 0; i < arr.length; i++) {
        let currentArr = arr[i].split(' ')
        
        turn++
        if (turn % 2 == 0) {
            mark = 'X'
        } else {
            mark = 'O'
        }

        if (matrix[currentArr[0]][currentArr[1]] != 'false'){
            console.log('This place is already taken. Please choose another!')
            turn--
            continue
        }

        matrix[currentArr[0]][currentArr[1]] = mark

        if (allEqual(matrix[currentArr[0]])) {
            console.log(`Player ${mark} wins!`)
            break
        }

        if(matrix[0][currentArr[1] == matrix[1][currentArr[1]]] && matrix[0][currentArr[1] == matrix[2][currentArr[1]]] && matrix[0][currentArr[1] != 'false']){
            console.log(`Player ${mark} wins!`)
            break
        }

        if(matrix[0][0] == matrix[1][1] && matrix[0][0] == matrix[2][2] && matrix[0][0] != 'false'){
            console.log(`Player ${mark} wins!`)
            break
        }

        if(matrix[0][2] == matrix[1][1] && matrix[0][2] == matrix[2][0] && matrix[0][2] != 'false'){
            console.log(`Player ${mark} wins!`)
            break
        }

        if(!matrix.some(row => row.includes('false'))){
            console.log('The game ended! Nobody wins :(')
            break
        }
        
    }
    console.log(matrix[0].join(`\t`))
    console.log(matrix[1].join(`\t`))
    console.log(matrix[2].join(`\t`))
}

solve(["0 1",
"0 0",
"0 2",
"2 0",
"1 0",
"1 2",
"1 1",
"2 1",
"2 2",
"0 0"]
)