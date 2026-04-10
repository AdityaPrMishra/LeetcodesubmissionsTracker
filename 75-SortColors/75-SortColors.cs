// Last updated: 10/04/2026, 13:38:39
1public class Solution {
2    public void SortColors(int[] nums) {
3        int low=0;
4        int mid=0;
5        int high=nums.Length-1;
6
7        while(mid<=high)
8        {
9            if(nums[mid]==0)
10            {
11                swap(nums, low, mid);
12                low++;
13                mid++;
14            }
15            else if(nums[mid]==1)
16            {
17                mid++;
18            }
19            else
20            {
21                swap(nums, mid, high);
22                high--;
23            }
24        }
25    }
26
27     public void swap(int[] nums, int i, int j )
28     {
29         int temp = nums[i];
30         nums[i]=nums[j];
31         nums[j]=temp;
32
33     }  
34   
35}