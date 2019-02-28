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
        
        ListNode dummy=new ListNode(0);//create
        ListNode ori=head;
        ListNode tail;
        ListNode tailParent;
        dummy.next=head;
        
        //if list is nothing, return nothing as well
        if (head==null) return null;
        //if there is only one head, return head its self.
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

    // a better solution
    public ListNode RotateRight2(ListNode head, int k){

         ListNode tail;
        ListNode tailParent;
        ListNode start=new ListNode(0);
        start.next=head;
        tail=head;
        tailParent=start;

        if (head==null) return null;
        //if there is only one head, return head its self.
        if (head.next==null) return head;
               
        int count=1;
        //get numbers of nodes
        while(tail.next!=null)
        {
            tailParent=tail;
            tail=tail.next;

            count++;
        }

        int R=k%count;//real number of times need to rotate to right.
     
        while (R>0)
        {
            start.next=tail;
            tailParent.next=null;
            R--;
            tail.next=head;
            head=tail;

            while(tail.next!=null)
            {
            tailParent=tail;
            tail=tail.next;
            }
        }
        return start.next;
    }

    //correct way!
    public ListNode RotateRight3(ListNode head, int k)
        {
         ListNode tail;
         ListNode start=null;
         tail=head;
         if (head==null) return null;
            //link to a ring
         int count=1;
        //get numbers of nodes
        while(tail.next!=null)
        {
            tail=tail.next;

            count++;
        }
        tail.next=head;
        int R=k%count;//real number of times need to rotate to right.

        int i=count-R; //index of the next head starting from 0..1..
        while(i>0)
        {
            start=head;
            head=head.next;
            i--;
        }    
        start.next=null;
            
            
        return head;
        }
    }
}