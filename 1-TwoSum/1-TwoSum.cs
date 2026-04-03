// Last updated: 3/4/2026, 2:38:58 pm
public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        var seen = new Dictionary <int, int >();

        for (int i=0; i<=nums.Length; i++)
        {
            var complement = target - nums[i];

            if(seen.ContainsKey(complement))
            return new int[] {seen[complement], i};

            seen[nums[i]]=i;

        }
        return new int[] {};
    }
}