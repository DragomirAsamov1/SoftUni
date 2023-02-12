class List{
    constructor(){
        this.elements = []
        this.size = 0
    }

    add(num){
        this.elements.push(num)
        this.size++
        return this.elements.sort((a,b) => a - b)
    }

    remove(index){
        if(index < this.elements.length && index >= 0){
            this.elements.splice(index, 1)
            this.size--
            return this.elements.sort((a,b) => a - b)
        }
    }

    get(index){
        if(index < this.elements.length && index >= 0){
            return this.elements[index]
        }
    }

    size(){
        return this.elements.length
    }
}

function createSortedList(){
    return new List()
}

let list = createSortedList();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1)); 
list.remove(1);
console.log(list.get(1));
