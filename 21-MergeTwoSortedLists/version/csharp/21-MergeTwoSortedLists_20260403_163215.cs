// Last updated: 3/4/2026, 4:32:15 pm
1/**
2 * Definition for singly-linked list.
3 * public class ListNode {
4 *     public int val;
5 *     public ListNode next;
6 *     public ListNode(int val=0, ListNode next=null) {
7 *         this.val = val;
8 *         this.next = next;
9 *     }
10 * }
11 */
12public class Solution {
13    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
14
15        ListNode dummy = new ListNode(0);
16        ListNode current = dummy;
17
18        while( list1 != null && list2 !=null)
19        {
20            if (list1.val <= list2.val)
21            {
22                current.next = list1;
23                list1= list1.next;
24
25            }
26           
27            else 
28            {
29              current.next = list2;
30              list2 = list2.next;
31
32            }
33            
34          current = current.next;
35
36        }
37            if (list1 != null) current.next = list1;
38            if (list2 != null) current.next = list2;
39
40            return dummy.next;
41    }
42}