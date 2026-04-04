// Last updated: 4/4/2026, 12:14:30 pm
1public class Solution {
2    public bool Check(int[] nums) {
3
4        int drops =0;
5        int n = nums.Length;
6
7        for (int i=0; i<n; i++)
8        {
9
10           if (nums[i]> nums[(i+1) % n])
11           drops++;
12           if (drops > 1) return false;
13             
14        }
15        return true;
16        
17    }
18}