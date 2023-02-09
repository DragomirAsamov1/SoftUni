function solve (param){
    if(param.length > 1){
        return Number(param[0]) + Number(param.pop())
    } else if (param.length == 1){
        return param[0]*2
    } else {
        return 0
    }
    
}