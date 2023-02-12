class Rect{
    constructor(width, height, color){
        this.width = width
        this.height = height
        this.color = color
    }

    calcArea(){
        return this.width * this.height
    }
}
function rectangle(width, height, color){
    return new Rect(width, height, color)
}

let rect = rectangle(4,5,'red')
console.log(rect.width)
console.log(rect.height)
console.log(rect.color)
console.log(rect.calcArea())