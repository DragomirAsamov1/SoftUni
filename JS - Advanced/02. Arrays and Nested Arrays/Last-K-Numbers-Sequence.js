function solve (n, k){

    let array = []
    array[0] = 1

    for (let i = 1; i < Number(n); i++) {
        let num = 0
        for (let j = 1; j <= Number(k); j++) {
            if(i-j < 0){
                continue;
            }


            num += array[i-j]
        }

        array.push(num)
    }

    return array
}
