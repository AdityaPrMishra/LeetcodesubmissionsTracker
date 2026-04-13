// Last updated: 13/04/2026, 12:49:39
1public class Solution {
2    public int MaxSubArray(int[] nums) {
3        int currentSum= nums[0];
4        int maxSum= nums[0];
5
6        for (int i=1; i<nums.Length; i++)
7        {
8           currentSum= Math.Max(nums[i], currentSum + nums[i]);
9           
10           maxSum= Math.Max(maxSum, currentSum);
11
12        }
13        return maxSum;
14    }
15}