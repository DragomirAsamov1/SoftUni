function solve(arr){
    arr.sort(function(a,b){
        if(a.length > b.length){
            return 1
        } else if(a.length < b.length){
            return -1
        } else {
            return a.localeCompare(b)
        }
    })

    arr.forEach(element => {
        console.log(element)
    });
}

solve(['alpha', 
'beta', 
'gamma']
)