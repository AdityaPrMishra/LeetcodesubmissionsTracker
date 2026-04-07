// Last updated: 07/04/2026, 20:42:49
1public class Solution {
2    public int FindMaxConsecutiveOnes(int[] nums) {
3        
4       int current =0;
5       int max=0;
6
7       foreach(int num in nums)
8       {
9          if (num == 1)
10          {
11            current++;
12            max=Math.Max(max, current);
13          }
14          else
15          {
16              current=0;
17          }
18
19       }
20       return max;
21
22    }
23}