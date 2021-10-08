const Node = () => {
    let keys = new Map();
    let _end = false;
    const setEnd = () => {return _end = true}
    const isEnd = () => {return _end}
    return { keys, setEnd, isEnd}
}

const Trie = () => {
    let root = Node();

    const add = (input, node = root) => {
        if(input.length == 0) {
            node.setEnd();
            return;
        } else if(!node.keys.has(input[0])) {   
            node.keys.set(input[0], Node());
            return add(input.substr(1), node.keys.get(input[0]));     
        } else {
            return add(input.substr(1),node.keys.get(input[0]));
        }
    }

    const isWord = (word) => {
        let node = root;

        while(word.length > 1) {
            if (!node.keys.has(word[0])) {
                return false;
            } else {
                node = node.keys.get(word[0]);
                word = word.substr(1); 
            }
        }
        return (node.keys.has(word) && node.keys.get(word).isEnd()) ? true : false;
    }

    const hasKey = (key) => {
        return root.keys.has(key);
    }

    return {add, isWord, hasKey};
}


// leet code problem index pair of strings
let text = "ababa";
let words = ["aba", "ab"]
let t = Trie();

for( let i = 0; i < words.length; i++) {
    t.add(words[i]);
}

let result = [];


for(let j = 0; j < text.length; j++) {
    if(t.hasKey(text[j])) {
        words.forEach((word,index) => {
            if(t.isWord(text.slice(j, j + words[index].length))) {
                result.push([j,j + words[index].length - 1]);
            }
        })
    }
}

result.sort((a,b)=> a[0] === b[0] ? a[1] - b[1] : a[0] - b[0]);

console.log(result);

