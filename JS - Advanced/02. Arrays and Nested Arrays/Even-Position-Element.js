function solve (param){
    let ouput = ''
    for (let i = 0; i < param.length; i+=2) {
        ouput += param[i] + ' '
        
    }

    console.log(ouput.trimEnd())
}