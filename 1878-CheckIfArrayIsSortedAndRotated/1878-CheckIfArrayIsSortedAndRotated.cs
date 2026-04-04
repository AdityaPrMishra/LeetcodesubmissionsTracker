// Last updated: 4/4/2026, 11:19:42 pm
public class Solution {
    public bool Check(int[] nums) {

        int drops =0;
        int n = nums.Length;

        for (int i=0; i<n; i++)
        {

           if (nums[i]> nums[(i+1) % n])
           drops++;
           if (drops > 1) return false;
             
        }
        return true;
        
    }
}