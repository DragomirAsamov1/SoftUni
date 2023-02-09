function solve (N, M){
    let num1 = Number(N)
    let num2 = Number(M)

    let result = 0

    for (let i = num1; i <= num2; i++){
        result += i
    }

    console.log(result);
}

solve('-8', '20')