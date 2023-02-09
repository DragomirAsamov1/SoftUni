function solve (speed, area){
    let speedLimit
    let status = ''
    switch(area){
        case 'motorway': 
            speedLimit = 130; break;
        case 'interstate':
            speedLimit = 90; break;
        case 'city':
            speedLimit = 50; break;
        case 'residential':
            speedLimit = 20; break;
            default: return
    }

    if(speed <= speedLimit){
        return `Driving ${speed} km/h in a ${speedLimit} zone`
    } else {
        if(speed - speedLimit <= 20){
            status = 'speeding'
        } else if (speed - speedLimit <= 40){
            status = 'excessive speeding'
        } else {
            status = 'reckless driving'
        }

        return `The speed is ${speed - speedLimit} km/h faster than the allowed speed of ${speedLimit} - ${status}`
    }
}

console.log(solve(200, 'motrway'));