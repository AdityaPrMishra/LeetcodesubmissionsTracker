// Last updated: 14/04/2026, 22:35:11
1public class Solution {
2 public int MaxProfit(int[] prices)
3{
4    int minPrice = prices[0];
5    int maxProfit = 0;
6
7    for (int i=0; i<prices.Length; i++ )
8    {
9        minPrice = Math.Min(minPrice, prices[i]);
10        int profit = prices[i] - minPrice; 
11        maxProfit = Math.Max(maxProfit, profit);
12    }
13    return maxProfit ;
14}
15}