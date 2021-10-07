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

    return {add, isWord};
}


let t = Trie();

t.add('what');
t.add('the');
t.add('fuck');
t.add('lol');

