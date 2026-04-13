// Last updated: 13/04/2026, 15:05:08
1public class Solution {
2    public int[] RearrangeArray(int[] nums) {
3        int n = nums.Length;
4        int [] result = new int[n];
5
6        int posIndex=0;
7        int negIndex=1;
8
9        for(int i =0; i<n; i++)
10        {
11            if (nums[i]>0)
12            {
13                result[posIndex]=nums[i];
14                posIndex+=2;
15            }
16            else 
17            {
18                result[negIndex]=nums[i];
19                negIndex+=2;
20            }
21        }
22        return result;
23
24        
25    }
26}