/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode current = head;
        
        // tail
        ListNode previous = null;

        while (current != null)
        {
            //  store the next reference so you dont lose it when overwriting
            ListNode tmp = current.next;

            // reverse
            current.next = previous;
            previous = current;

            // advance to next node
            current = tmp;
        }

        return previous;
    }
}
