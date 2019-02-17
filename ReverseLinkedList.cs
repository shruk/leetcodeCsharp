using Xunit;

namespace ReverseLinkedList
{
    /**
 * Definition for singly-linked list.*/
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }
 
public class Solution {
    public static ListNode ReverseList(ListNode head) {
        ListNode dummy=new ListNode(0);
        ListNode newList=dummy;
        
        if (head==null)return null;
        
        
        //put first one in
        
        //dummy.next=head;
        //head=head.next;
        //newList=newList.next;
        
        while (head!=null)
        {
            newList=dummy.next;
            dummy.next=head;
            head=head.next;
            dummy.next.next=newList;
            newList=dummy.next;
            
            
        }
        
        
        
        return dummy.next;
        
    }
}

    public class ReverseLinkedListTest
    {
        [Fact]
        public void Test1()
        { ListNode l1=new ListNode(1);
        l1.next=new ListNode(2);
        l1.next.next=new ListNode(4);

        ListNode l2=new ListNode(1);
        l2.next=new ListNode(3);
        l2.next.next=new ListNode(4);



        ListNode l3=    Solution.ReverseList(l1);
        }
    }

}