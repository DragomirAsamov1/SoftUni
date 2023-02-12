function solve(arr){

    let towns = {}
    for (let i = 0; i < arr.length; i++) {
        let info = arr[i].split(' <-> ')

        if(!towns[info[0]]){
            towns[info[0]] = 0
        }

        towns[info[0]] += Number(info[1])
    }

    for (const [key, value] of Object.entries(towns)) {
        console.log(`${key} : ${value}`)
    }
}

solve(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']
)