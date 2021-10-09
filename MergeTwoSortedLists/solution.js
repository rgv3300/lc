function ListNode(val, next) {
    this.val = (val === undefined ? 0 : val);
    this.next = (next === undefined ? null : next);
}

let node1 = new ListNode(123)
let node2 = new ListNode(3300)
let node3 = new ListNode(54000)
let node4 = new ListNode(754000)
let node5 = new ListNode(9000002)
node1.next = node2;
node2.next = node3;
node3.next = node4;
node4.next = node5;

let lnode1 = new ListNode(22)
let lnode2 = new ListNode(42)
let lnode3 = new ListNode(260)
let lnode4 = new ListNode(3480)
let lnode5 = new ListNode(11000)
lnode1.next = lnode2;
lnode2.next = lnode3;
lnode3.next = lnode4;
lnode4.next = lnode5;

((l1, l2) => {
    let l3 = [];
    while (l1 != null && l2 != null) {
        if (l1.val < l2.val) {
            l3.push(l1.val);
            l1 = l1.next;
        } else {
            l3.push(l2.val);
            l2 = l2.next;
        }
    }
    if (l1 == null) {
        while (l2 != null) {
            l3.push(l2.val);
            l2 = l2.next;
        }
    } else {
        while (l1 != null) {
            l3.push(l1.val);
            l1 = l1.next;
        }
    }

    console.log(l3);
    return l3;
})(node1, lnode1)