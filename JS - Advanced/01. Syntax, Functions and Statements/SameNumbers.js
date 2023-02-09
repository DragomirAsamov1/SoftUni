function solve (num){
    let sum = 0;
    let check = true
    let numToCheck = num % 10

    while(num){
        let tempNum = num % 10
        num = Math.floor(num / 10)
        if(numToCheck != tempNum){
            check = false
        }
        sum += tempNum
    }
    console.log(check);
    console.log(sum)
}

solve(2222222)