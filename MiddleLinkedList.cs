using Xunit;

namespace MiddleLinkedList
{


/**
 * Definition for singly-linked list. */
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
 }

public class Solution {
    public static ListNode MiddleNode(ListNode head) {
        ListNode dummy=new ListNode(0);
        dummy.next=head;
        ListNode original=head;
        //get count of linked list
        int count=0;
        while (head!=null)
        {
            head=head.next;
            count++;
        }
        int midIndex=count/2;
        
        
        for (int i=0;i<midIndex; i++)
        {
            original=original.next;
        }
        
        return original;
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


        ListNode l3=    Solution.MiddleNode(l1);
        
        }
    }

}