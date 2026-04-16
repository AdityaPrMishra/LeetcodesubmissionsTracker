// Last updated: 16/04/2026, 14:33:46
1public class Solution {
2    public void NextPermutation(int[] nums) {
3        int n =nums.Length;
4        int i = n-2;
5
6        // Find the Pivot
7        while (i>=0 && nums[i]>= nums[i+1])
8        {
9            i--;
10        }
11
12        if(i>=0)
13        {
14            int j = n-1;
15            // Find larger number than pivot
16            while (nums[j]<=nums[i])
17            {
18                j--;
19            }
20            Swap(nums, i , j);
21        }
22        // Reverse the side side 
23        Reverse ( nums, i+1, n-1);
24        
25
26    }
27
28private void Swap(int[] nums, int i, int j)
29{
30    int temp = nums[i];
31    nums[i] = nums[j];
32    nums[j] = temp;
33}
34
35private void Reverse(int[] nums, int start, int end)
36{
37    while (start < end)
38    {
39        Swap(nums, start, end);
40        start++;
41        end--;
42    }
43}
44}