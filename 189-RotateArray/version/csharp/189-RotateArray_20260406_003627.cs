// Last updated: 6/4/2026, 12:36:27 am
1public class Solution {
2    public void Rotate(int[] nums, int k) {
3
4       int n = nums.Length;
5       k=k%n;
6
7       Reverse(nums, 0, n-1);
8       Reverse(nums, 0, k-1);
9       Reverse(nums, k, n-1);
10
11    }
12       private void Reverse(int[]nums, int left, int right)
13       {
14
15           while (left<right)
16           {
17             int temp =nums[left];
18             nums[left]=nums[right];
19             nums[right]=temp;
20             left++;
21             right--;
22
23           }
24
25       } 
26        
27    
28}