function solve(obj){
    let resultCar = {
        model: obj.model,
    }
    
    let smallEngine = {
        power: 90,
        volume: 1800
    }

    let normalEngine = {
        power: 120,
        volume: 2400
    }

    let monsterEngine = {
        power: 200,
        volume: 3500
    }

    resultCar.engine = {}

    if(obj.power <= 90){
        resultCar.engine.power = smallEngine.power
        resultCar.engine.volume = smallEngine.volume
    } else if (obj.power <= 120){
        resultCar.engine.power = normalEngine.power
        resultCar.engine.volume = normalEngine.volume
    } else {
        resultCar.engine.power = monsterEngine.power
        resultCar.engine.volume = monsterEngine.volume
    }

    resultCar.carriage = {}

    if(obj.carriage == 'hatchback'){
        resultCar.carriage.type = 'hatchback'
    } else if (obj.carriage == 'coupe'){
        resultCar.carriage.type = 'coupe'
    }

    resultCar.carriage.color = obj.color

    let wheel

    if(obj.wheelsize % 2 == 0){
        wheel = obj.wheelsize - 1        
    } else {
        wheel = obj.wheelsize
    }

    resultCar.wheels = [wheel, wheel, wheel, wheel]

    return resultCar
}

console.log(solve({ model: 'VW Golf II',
power: 90,
color: 'blue',
carriage: 'hatchback',
wheelsize: 14 }
))