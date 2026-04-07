// Last updated: 08/04/2026, 01:30:29
1public class Solution {
2    public int SingleNumber(int[] nums) {
3        int result=0;
4        foreach(int num in nums)
5        {
6            result^=num;
7        }
8        return result;
9    }
10}