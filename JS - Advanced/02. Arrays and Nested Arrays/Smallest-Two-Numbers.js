function solve (arr){

    arr.sort(function (a,b){return b-a})
    console.log(arr.pop() + ' ' + arr.pop())

}