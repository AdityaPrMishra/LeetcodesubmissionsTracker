// Last updated: 17/04/2026, 15:25:32
public class Solution {
 public int MaxProfit(int[] prices)
{
    int minPrice = prices[0];
    int maxProfit = 0;

    for (int i=0; i<prices.Length; i++ )
    {
        minPrice = Math.Min(minPrice, prices[i]);
        int profit = prices[i] - minPrice; 
        maxProfit = Math.Max(maxProfit, profit);
    }
    return maxProfit ;
}
}