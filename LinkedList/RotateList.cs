namespace RotateList{
/**
 * Definition for singly-linked list.*/
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }
 
public class Solution {
    //the original solution works but too slow！！！
    public static ListNode RotateRight(ListNode head, int k) {
        
        ListNode dummy=new ListNode(0);
        ListNode ori=head;
        ListNode tail;
        ListNode tailParent;
        dummy.next=head;
        
        //nothing
        if (head==null) return null;
        //just one head
        if (head.next==null) return head;
        
        while(k>0)
        {
        //2 elements
        if (head.next.next==null){tail=head.next; tailParent=head;}
        else{
        while(head.next.next!=null)
        {
            
            head=head.next;
        }
        
        
         tail=head.next;
         tailParent=head;
        }
        
        dummy.next=tail;
        tailParent.next=null;
        tail.next=ori;
        k--;
            
        head=tail;
        ori=head;
            
        }
        return dummy.next;
        
    }
    }
}