// Last updated: 20/04/2026, 23:21:01
1public class Solution {
2    public int SearchInsert(int[] nums, int target) {
3        
4        int left = 0;
5        int right = nums.Length - 1;
6
7        while(left<=right)
8        {
9
10             int mid = left + (right - left) / 2;
11
12            if (nums[mid] == target) 
13            {
14            return mid;
15            }
16            else if (nums[mid] < target)
17            {
18                left = mid + 1;
19            }
20            else 
21            {
22                right = mid - 1;
23            }           
24        }
25        return left;
26    }
27}
28