function solve(arr){
    arr.sort()

    let index = 0

    arr.forEach(name => {
        index++
        console.log(`${index}.${name}`)
    });
}

solve(["John", "Bob", "Christina", "Ema"])