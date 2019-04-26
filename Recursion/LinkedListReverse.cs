
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
        
        // Accepted Solution, In place iterative solution
        // Time Complexity O(n)
        // Space Complexity O(1)
        public Node<int> ReverseLinkedListProIter(Node<int> head)
        {
            Node<int> pre=null;
            Node<int> curr=head;
            while(curr!=null)
            {
                Node<int> nextTemp=curr.next;
                curr.next=pre;
                pre=curr;
                curr=nextTemp;
            }
            return pre;
        }
        // Recusively solve.
        // Head + Reverse(rest)=> head + Reverse(head.next).
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
        
        // Recursive accepted solution.
        // The recursion relation is f(n)=head<-f(n-1).
        // Base case is head = head.
        // Think when head->tail, f(1)=tail; head.next.next=head;head.next=null
        // Think when head->node->tail, => head->node<-tail
        public Node<int> ReverseLinkedListProRec(Node<int> head)
        {
            // Base case:
            if (head==null || head.next == null)
            {
                return head;
            }
             Node<int> p=ReverseLinkedListProRec(head.next);
             head.next.next=head;
             head.next=null;
             return p;
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

        public Node<int> CreateNode
        {
            get {            
                var n1=new Node<int>(1);
                var n2=new Node<int>(2);
                var n3=new Node<int>(3);
                var n4=new Node<int>(4);
                n1.next=n2;
                n2.next=n3;
                n3.next=n4;
                return n1;
                }
        }

        [Fact]
        public void TestReverseLinkedList()
        {
            var n1=CreateNode;
            _o.PrintLinkedList(_o.ReverseLinkedList(n1));
            n1=CreateNode;
            _o.PrintLinkedList(_o.ReverseLinkedListRec(n1));
            n1=CreateNode;
            _o.PrintLinkedList(_o.ReverseLinkedListProIter(n1));
            n1=CreateNode;
            _o.PrintLinkedList(_o.ReverseLinkedListProRec(n1));
        }

        // Define a method to initilize speedtester with method handler
        public void MethodHanderRec()
        {
            var n1=CreateNode;
            _o.ReverseLinkedListRec(n1);
        }
        public void MethodHanderIter()
        {
            var n1=CreateNode;
            _o.ReverseLinkedList(n1);
        }
        public void MethodHanderProIter()
        {
            var n1=CreateNode;
            _o.ReverseLinkedListProIter(n1);
        }
        public void MethodHanderProRec()
        {
            var n1=CreateNode;
            _o.ReverseLinkedListProRec(n1);
        }

        [Fact]
        public void TestSpeed()
        {
            _st=new SpeedTester(MethodHanderIter);
            _st.RunTest();
            _output.WriteLine($"Iterative function Total running is : {_st.TotalRunningTime} milisec");
            _st.method=MethodHanderRec;
            _st.RunTest();
            _output.WriteLine($"Recursive function Total running time is: {_st.TotalRunningTime} milisec");
            _st.method=MethodHanderProIter;
            _st.RunTest();
            _output.WriteLine($"Pro Iterative function Total running time is: {_st.TotalRunningTime} milisec");
            //_st=new SpeedTester(MethodHanderProRec);
            _st.method=MethodHanderProRec;
            _st.RunTest();
            _output.WriteLine($"Pro Recursive function Total running time is: {_st.TotalRunningTime} milisec");
        }

        [Fact]
        public override void TestPerformance()
        {
            var n1=CreateNode;
            for (int i=0;i<=1000;i++)
            {
               // var n=new Node(random number);
            }
        }

    }
}