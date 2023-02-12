function solve(input){

    class Town {
        constructor(name, latitude, longitude){
            this.name = name
            this.latitude = latitude
            this.longitude = longitude
        }
    }

    let register = []

    for (let i = 1; i < input.length; i++) {
        let arr = input[i].split('|')
        let name = arr[1].trim()
        let latitude = Math.round(arr[2].trim() * 100) / 100
        let longitude = Math.round(arr[3].trim() * 100) / 100

        let town = new Town(name, latitude, longitude)

        let townForJSON = {}

        townForJSON['Town'] = town.name
        townForJSON['Latitude'] = town.latitude
        townForJSON['Longitude'] = town.longitude

        let objectToJSON = JSON.stringify(townForJSON, function (key, value) {
            if(key == 'Latitude' || key == 'Longitude'){
                return Number(value)
            } else {
                return value
            }
        })
        register.push({objectToJSON})
        
    }

    console.log(register.join(','))
}

solve(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']
)