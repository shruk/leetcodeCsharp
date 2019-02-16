
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
    
    public static ListNode MergeTwoLists(ListNode l1, ListNode l2) {
      //we start with 2 nodes, we need to compare them
        
      final=l1.val>l2.val?l2:l1;
        //since we pick the smaller one for head, the head.next need to compare with the bigger one
      if(final==l1)//l1 is smaller
      {l1=l1.next;
          
      }else{l2=l2.next;}
        
        
      final.next=Smaller(l1,l2);
        
        return final;
    }
    
    private static ListNode Smaller(ListNode l1,ListNode l2)
    {//check null here
        if (l1==null&&l2==null)
        {return null;}
      
        if (l1==null)
        {return l2;}
        
        if (l2==null)
        {return l1;}
        
        return l1.val>l2.val?l2:l1;

    }
    
    
}

    public class Merge2LinkedListTest
    {
        [Fact]
        public void Test1()
        { ListNode l1=new ListNode(1);
        l1.next=new ListNode(2);
        l1.next.next=new ListNode(4);

        ListNode l2=new ListNode(1);
        l2.next=new ListNode(3);
        l2.next.next=new ListNode(4);



        ListNode l3=    Solution.MergeTwoLists(l1,l2);
        }
    }
}