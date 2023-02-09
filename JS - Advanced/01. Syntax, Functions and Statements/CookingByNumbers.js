function solve(...input){
    let num = Number(input[0])

    for(let i = 1; i < input.length; i++){
        switch(input[i]){
            case 'chop':
                num /= 2; break;
            case 'dice':
                num = Math.sqrt(num); break;
            case 'spice':
                num += 1; break;
            case 'bake':
                num *= 3; break;
            case 'fillet':
                num -= num * 0.2; break;
            default: break;
        }

        console.log(num)
    }
}

solve('9', 'dice', 'spice', 'chop', 'bake', 'fillet')