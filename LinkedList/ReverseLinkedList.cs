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
    //this solution is ok but not ideal as created extra vairable and complexity...
    public static ListNode ReverseList(ListNode head) {
        ListNode dummy=new ListNode(0);
        ListNode newList=dummy;
        
        if (head==null)return null;
        while (head!=null)
        {
            newList=dummy.next;//hold current dummy.next
            dummy.next=head;//point dummy to the new head
            head=head.next;//move head to next
            dummy.next.next=newList;//connect head to current new list
            newList=dummy.next;//move new to the new head
        }
        return dummy.next;
    }

    public static ListNode ReverseList2(ListNode head){
        //ListNode dummy;
        while (head!=null){}
        return null;
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