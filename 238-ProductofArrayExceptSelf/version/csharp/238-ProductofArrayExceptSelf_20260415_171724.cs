// Last updated: 15/04/2026, 17:17:24
1public class Solution {
2    public int[] ProductExceptSelf(int[] nums) {
3        
4        int n = nums.Length;
5
6        int[] result = new int[n];
7
8        result[0]=1;
9       // Prefix pass
10        for (int i=1; i<n ; i++)
11        {
12            result[i]= result[i-1] * nums[i-1];
13        }
14
15        int suffix=1;
16
17         // Suffix pass
18        for(int i = n-1; i>=0; i--)
19        {
20            result[i] = result[i] * suffix;
21            suffix = suffix * nums[i];
22        }
23
24
25        return result;
26    }
27}