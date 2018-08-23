namespace leetcodeCSharp
{
    public class MiddleOfTheLinkedList876
    {/**
      * Definition for singly-linked list.
      * public class ListNode {
      *     public int val;
      *     public ListNode next;
      *     public ListNode(int x) { val = x; }
      * }
      */
        
        public ListNode MiddleNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            return slow;
        } 
    }
}