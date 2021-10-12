// 

function maxProfitCalculatorBruteForce(prices) {
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


function maxProfitCalculatorOpt(prices) {
    let minPrice = Number.MAX_SAFE_INTEGER;
    let maxProfit = 0;
    for(let i = 0; i < prices.length; i++) {
        if(prices[i] < minPrice) {
            minPrice = prices[i]
        } else if(prices[i] - minPrice > maxProfit) {
            maxProfit = prices[i] - minPrice;
        }
    }
    console.log(maxProfit + 'opt')
    return maxProfit;
}




let prices = [7,1,5,3,6,4];

maxProfitCalculatorBruteForce(prices);
maxProfitCalculatorOpt(prices);