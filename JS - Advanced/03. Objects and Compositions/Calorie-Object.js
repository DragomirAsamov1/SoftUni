function solve(arr){
    let product = {}
    for (let i = 0; i < arr.length; i+= 2) {
        product[arr[i]] = Number(arr[i+1])
    }

    console.log(product)
}

solve (['Yoghurt', '48', 'Rise', '138', 'Apple', '52'])