function solve(input){
    let regexp = /\w+/g;

    let matches = input.match(regexp)

    matches = matches.map(function(x){ return x.toUpperCase()})

    console.log(matches.join(', '));
}

solve('Hi, how are you?')