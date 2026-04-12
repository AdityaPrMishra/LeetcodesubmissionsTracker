// Last updated: 12/04/2026, 15:14:42
1public class Solution {
2    public int MajorityElement(int[] nums) {
3
4      int candidate=0;
5      int count =0;
6
7      for (int i=0; i<nums.Length; i++)
8      {
9        if (count==0)
10        {
11            candidate=nums[i];
12        }
13        if(nums[i]==candidate)
14        {
15            count++;
16        }
17        else
18        {
19          count--;
20        }
21      }
22      return candidate;
23    }
24}