function solve (...arr){
    let x1 = Number(arr[0])
    let y1 = Number(arr[1])
    let x2 = Number(arr[2])
    let y2 = Number(arr[3])

    function distance(x1, y1, x2, y2){
        let distX = x2-x1
        let distY = y2-y1
        return Math.sqrt(distX**2 + distY**2)
    }
    
    let result = ''

    if(Number.isInteger(distance(x1, y1, 0, 0))){
        result = 'valid'
    } else {
        result = 'invalid'
    }
    console.log(`{${x1}, ${y1}} to {0, 0} is ${result}`);

    if(Number.isInteger(distance(x2, y2, 0, 0))){
        result = 'valid'
    } else {
        result = 'invalid'
    }
    console.log(`{${x2}, ${y2}} to {0, 0} is ${result}`);

    if(Number.isInteger(distance(x1, y1, x2, y2))){
        result = 'valid'
    } else {
        result = 'invalid'
    }
    console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is ${result}`);
}



solve(2, 1, 1, 1)