let items = [[1,91],[1,92],[2,93],[2,97],[1,60],[2,77],[1,65],[1,87],[1,100],[2,100],[2,76]];


var highFive = function(items) {
    let m = new Map();
    for(let i = 0; i < items.length; i++){
        if(m.has(items[i][0])){
            m.get(items[i][0]).score.push(items[i][1]);
        } else {
            m.set(items[i][0],{score : [items[i][1]]})
        }
    }
    return m;
};

let m1 = highFive(items);

m1.forEach((value,key) => {
    m1.set(key,value.score.sort(function(a, b){return a-b}).splice(0,5).reduce((initialValue, currentValue) => {
        return initialValue + currentValue;
    }) / value.score.length)
})

console.log(m1);   