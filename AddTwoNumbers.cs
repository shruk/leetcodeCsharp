using System;
using System.Collections.Generic;
using Xunit;

namespace leetcodeCsharp
{

/**
 * Definition for singly-linked list. */
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }

      public override string ToString()
      {
          ListNode current=this;
          string result=null;
          while(current!=null)
          {
            result=result+current.val.ToString();
              current=current.next;
          }
          return result;
      } 
  }

public class Solution {
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        //original solution
        int number1=0;
        int number2=0;
        int time1=1;
        while (l1!=null)
        {
            number1=number1+l1.val*time1;
            time1=time1*10;
            l1=l1.next;

        }
        
        int time2=1;
        while(l2!=null)
            {
                number2=number2+l2.val*time2;
                        time2=time2*10;
            l2=l2.next;
            }
        int number3=number1+number2;
        Console.WriteLine(number3.ToString());//0
        //Console.WriteLine(time3.ToString());//1
        //Console.WriteLine(number3/time3);//8
        Console.WriteLine(number3%10);//7
        
        ListNode l3=null;
        ListNode tmp=null;
        
        
            List<int> listOfInts = new List<int>();
        
        if (number3==0){return new ListNode(0);}
            while(number3 > 0)
            {
                
                listOfInts.Add(number3 % 10);
                number3 = number3 / 10;
                
            }
            listOfInts.Reverse();
             foreach (int i in listOfInts)
             {
                 Console.WriteLine(i.ToString());
                 ListNode newnode=new ListNode(i);
                 if(l3==null)
                 {l3=newnode;}
                 else{
                     tmp=l3;
                     l3=newnode;
                    l3.next=tmp;}
             }

        return l3;
        
    }

//using guideline of adding digit by digit, the solution is not idea but it is correct for approval!
    public static ListNode AddTwoNumbers2(ListNode l1, ListNode l2){
           int loop=leng(l1)>leng(l2)?leng(l1):leng(l2);
        ListNode result=null;
        ListNode current=null;
        bool carry=false;
        int val;
                
              for (int i=0;i<loop;i++)
                {
                    int value1;
                    int value2;

                   if (carry)
                    {val=1;}
                   else {val=0;}
                    
                    if (l1!=null)
                    {value1=l1.val;
                    l1=l1.next;}
                    else{value1=0;}
                     if (l2!=null)
                    {value2=l2.val;l2=l2.next; }
                    else{value2=0;}


                   val+=value1 +value2;
                   

                    int d;
                    if (val>=10){ d=val%10;
                     carry=true;}
                    else {d=val;carry=false;}

                    ListNode newnode=new ListNode(d);
                    if (result ==null){result=newnode;current=result;}
                    else{current.next=newnode;current=newnode;}

                }
        
                        if (carry)
                {
                    ListNode newnode1=new ListNode(1);
                    current.next=newnode1;}


        return result;
    }
    
        private static int leng(ListNode li)
    {   int len=0;
        ListNode current=li;
          while(current!=null)
          {
              len+=1;
              current=current.next;
          } 
          return len;
    }
}




    public class AddTwoNumbers
    {
        [Fact]
        public void Test1()
        {
            ListNode l1=new ListNode(1);
            Assert.Equal(l1.ToString(),"1");
            ListNode l2=new ListNode(2);
            Assert.Equal(l2.ToString(),"2");
            ListNode l3=Solution.AddTwoNumbers(l1,l2);
            Assert.Equal(l3.ToString(),"3");
            l1.next=new ListNode(2);//l1: 1->2   (21)
            l2.next=new ListNode(5);//l2: 2->5   (52)
            l3=Solution.AddTwoNumbers(l1,l2);     //l3 3->7
            Assert.Equal("37",l3.ToString());
        }
    }
}
