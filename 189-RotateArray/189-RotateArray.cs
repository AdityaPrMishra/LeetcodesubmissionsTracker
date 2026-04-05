// Last updated: 6/4/2026, 12:36:36 am
public class Solution {
    public void Rotate(int[] nums, int k) {

       int n = nums.Length;
       k=k%n;

       Reverse(nums, 0, n-1);
       Reverse(nums, 0, k-1);
       Reverse(nums, k, n-1);

    }
       private void Reverse(int[]nums, int left, int right)
       {

           while (left<right)
           {
             int temp =nums[left];
             nums[left]=nums[right];
             nums[right]=temp;
             left++;
             right--;

           }

       } 
        
    
}