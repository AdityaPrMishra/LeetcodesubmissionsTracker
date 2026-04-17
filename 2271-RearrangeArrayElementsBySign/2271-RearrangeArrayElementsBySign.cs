// Last updated: 17/04/2026, 15:25:19
public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int n = nums.Length;
        int [] result = new int[n];

        int posIndex=0;
        int negIndex=1;

        for(int i =0; i<n; i++)
        {
            if (nums[i]>0)
            {
                result[posIndex]=nums[i];
                posIndex+=2;
            }
            else 
            {
                result[negIndex]=nums[i];
                negIndex+=2;
            }
        }
        return result;

        
    }
}