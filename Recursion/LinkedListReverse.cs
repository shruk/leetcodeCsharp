using System.Text;
using leetcodeCsharp.Util;
using Xunit;
using Xunit.Abstractions;

namespace leetcodeCsharp.Recursion
{
    public class LinkedListReverse:Base
    {

        public LinkedListReverse(ITestOutputHelper _output):base(_output)
        {

        }

        //Iteratively
        //1->2->3->4->5->6
        //6->5->4->3->2->1
        public Node<int> ReverseLinkedList(Node<int> head)
        {
          // Declare a dummy as a new linked list
          // Move last tail to head.next of the new dummy list
          // Iterate over the original list and return the new list
          // Time Complexity O(n^2)
            
            if (head==null)
            {
                return null;
            }
            Node<int> dummy=new Node<int>(0); // Node to lead the next Linked list
            Node<int> pre=head;// Assign reference of head to pre
            Node<int> tail=head.next;// Assign reference of head.next to tail
            Node<int> builder=dummy; // Builder for the next linked list
            bool isComplete=false;
            while(!isComplete)
            {        
                pre=head;
                tail=pre.next;
                if (tail!=null)
                {
                while (tail.next!=null)
                {

                    pre=pre.next;// Move pre forward
                    tail=pre.next;// Move tail forward
                }
                //Remove tail from original list
                pre.next=null;
                //Building new list
                builder.next=tail;
                builder=builder.next;
                }
                else
                {
                    isComplete=true;
                }
            }
            builder.next=head;
            return dummy.next;
        }
        
        //Recusively solve
        //head + Reverse(rest)=> head + Reverse(head.next)
        public Node<int> ReverseLinkedListRec(Node<int> head)
        {
            if (head ==null)
            {
                return null;
            }
            Node<int> builder;
            Node<int> tail;
            Node<int> pre;
            if (head!=null && head.next==null)
            {// Only one head left, return it.
                return head;
            }
            else
            {// Find tail, then add tail and remove tail from original list, 
                // Continue to the next link
                pre=head;
                tail=head.next;
                while (tail.next!=null)
                {
                    pre=tail;
                    tail=tail.next;
                }
                pre.next=null; // Cut tail
                builder=tail;
                builder.next=ReverseLinkedListRec(head);
                
            }
            return builder;
        }
        public void PrintLinkedList(Node<int> head)
        {
            StringBuilder sb =new StringBuilder();
            while (head!=null)
            {
                sb.Append($"{head.data}->");
                head=head.next;
            }
            _output.WriteLine(sb.ToString());
        }
    }
    public class LinkedListReverseTest:BaseTest
    {
        private LinkedListReverse _o;
        public LinkedListReverseTest(ITestOutputHelper output):base(output)
        {
            _o=new LinkedListReverse(output);
        }

        [Fact]
        public void TestReverseLinkedList()
        {
            var n1=new Node<int>(1);
            var n2=new Node<int>(2);
            var n3=new Node<int>(3);
            var n4=new Node<int>(4);
            n1.next=n2;
            n2.next=n3;
            n3.next=n4;
            _o.PrintLinkedList(_o.ReverseLinkedList(n1));
             n1=new Node<int>(1);
             n2=new Node<int>(2);
             n3=new Node<int>(3);
             n4=new Node<int>(4);
            n1.next=n2;
            n2.next=n3;
            n3.next=n4;
            _o.PrintLinkedList(_o.ReverseLinkedListRec(n1));
        }

        // Define a method to initilize speedtester with method handler
        public void MethodHanderRec()
        {
            var n1=new Node<int>(1);
            var n2=new Node<int>(2);
            var n3=new Node<int>(3);
            var n4=new Node<int>(4);
            n1.next=n2;
            n2.next=n3;
            n3.next=n4;
            _o.ReverseLinkedListRec(n1);
        }

        public void MethodHanderIter()
        {
            var n1=new Node<int>(1);
            var n2=new Node<int>(2);
            var n3=new Node<int>(3);
            var n4=new Node<int>(4);
            n1.next=n2;
            n2.next=n3;
            n3.next=n4;
            _o.ReverseLinkedList(n1);
        }

        [Fact]
        public void TestSpeed()
        {
            _st=new SpeedTester(MethodHanderIter);
            _st.RunTest();
            _output.WriteLine($"Iterative function Total running is : {_st.TotalRunningTime} milisec");
            _st=new SpeedTester(MethodHanderRec);
            _st.RunTest();
            _output.WriteLine($"Recursive function Total running time is: {_st.TotalRunningTime} milisec");
        }

    }
}