// Last updated: 17/04/2026, 15:25:31
public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0)
        return 0;

        // Put all numbers into set
        HashSet<int> set = new HashSet<int>(nums);
        foreach(int num in nums)
        {
            set.Add(num);
        }

        int longest = 0;

        foreach(int num in set)
        {
             if(!set.Contains(num-1))
            {
                int Currentnum = num;
                int length =1;
            

                // Expand forward 
                 while ( set.Contains(Currentnum + 1))
                {
                  Currentnum++;
                  length++;
                }
                 longest = Math.Max(longest, length);
            }
        
        }
        return longest;
    }
}