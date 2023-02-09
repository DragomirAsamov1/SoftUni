function solve (arr, firstPie, secPie){
    let index = arr.indexOf(firstPie)
    let endIndex = arr.indexOf(secPie)
    return arr.slice(index, endIndex + 1)
}

solve(['Pumpkin Pie',
'Key Lime Pie',
'Cherry Pie',
'Lemon Meringue Pie',
'Sugar Cream Pie'],
'Key Lime Pie',
'Lemon Meringue Pie'
)