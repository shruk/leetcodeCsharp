using Xunit;

namespace RemoveDupSortedList{

/**
 * Definition for singly-linked list.*/
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }
 
public class Solution {
    public static ListNode DeleteDuplicates(ListNode head) {
        ListNode dummy=new ListNode(0);
        ListNode l2=dummy;
        
        if (head==null)
        return null;
        //get in head without comparing since no dup possible
        l2.next=head;
        
        l2=l2.next;
        head=head.next;
        while (head!=null)
        {
            if (head.val!=l2.val){
                
                l2.next=head;
                head=head.next;
                l2=l2.next;}
            else 
            {   l2.next=null;
                head=head.next;  }
            
            
        }
        
        
        return dummy.next;
        
        
    }
}




    public class RemoveDupSortedListTest
    {
        [Fact]
        public void Test1()
        { ListNode l1=new ListNode(1);
        l1.next=new ListNode(2);
        l1.next.next=new ListNode(4);
l1.next.next=new ListNode(4);
l1.next.next=new ListNode(4);


        ListNode l3=    Solution.DeleteDuplicates(l1);
        
        }
    }

}