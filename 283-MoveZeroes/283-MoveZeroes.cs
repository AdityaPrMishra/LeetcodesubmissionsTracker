// Last updated: 06/04/2026, 22:44:06
1public class Solution {
2    public void MoveZeroes(int[] nums) {
3
4        int j=0;
5
6        for(int i =0; i<nums.Length;i++)
7        {
8            if(nums[i]!=0)
9            {
10                nums[j]=nums[i];
11                j++;
12            }
13
14        }
15        
16        while(j<nums.Length)
17        {
18            nums[j]=0;
19            j++;
20        }
21    }
22}