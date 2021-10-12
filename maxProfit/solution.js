// 

function maxProfitCalculator(prices) {
    let maxEarnings = 0;
    for(let i = 0 ; i < prices.length; i++) {
        for(let j = i + 1; j < prices.length; j++) {
            let earningForTheDay = prices[j] - prices[i]
            if(maxEarnings < earningForTheDay) {
                maxEarnings = earningForTheDay
            }
        }
    }
    console.log(maxEarnings)
    return maxEarnings;
}

let prices = [7,1,5,3,6,4];

maxProfitCalculator(prices);