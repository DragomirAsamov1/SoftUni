function solve(array){

    console.log(array.reduce((a,b) => a + b));

    let inverseSum = 0
    array.forEach(element => {
        inverseSum += 1/element
    })
    console.log(inverseSum);

    console.log(array.join(''));

}


solve([1,2,3])