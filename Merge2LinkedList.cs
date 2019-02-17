
using Xunit;


namespace Merge2LinkedList{



/**
* Definition for singly-linked list.*/
public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }
 
public class Solution {
    
    static ListNode final;
    
  public  static ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode dummy=new ListNode(0);//this is for the final output, the dummy will point to l3;
        ListNode l3=dummy;
        
        while (l1!=null && l2!=null)
        {
            if (l1.val<=l2.val){l3.next=l1; l1=l1.next;}
            else {l3.next=l2; l2=l2.next;}
            l3=l3.next;
        }
        
        if (l1==null&&l2!=null){l3.next=l2;}
        if (l2==null&&l1!=null){l3.next=l1;}
        if (l1==null&l2==null){l3=l3;}
        
        return dummy.next;
    }
}
 
    public class Merge2LinkedListTest
    {
        [Fact]
        public void Test1()
        { ListNode l1=new ListNode(1) ;
        l1.next=new ListNode(2);
        l1.next.next=new ListNode(4);

        ListNode l2=new ListNode(1);
        l2.next=new ListNode(3);
        l2.next.next=new ListNode(4);



        ListNode l3=    Solution.MergeTwoLists(l1,l2);
        }
    }
}