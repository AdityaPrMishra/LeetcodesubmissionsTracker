// Last updated: 4/4/2026, 11:13:33 pm
1public class Solution {
2    public int RemoveDuplicates(int[] nums) {
3
4        if(nums.Length==0) return 0;
5
6        int slow =0;
7
8        for( int fast=1; fast<nums.Length; fast++)
9        {
10            if (nums[fast]!=nums[slow])
11             {
12               slow++;
13               nums[slow]=nums[fast];
14
15             }
16        }
17        return slow+1;
18    }
19}