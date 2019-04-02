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
            Node<int> dummy=new Node<int>(0);
            Node<int> runner=head;
            Node<int> builder=new Node<int>(0);
            dummy.next=builder;
            bool isComplete=false;
            while(!isComplete)
            {         
                while (runner.next!=null)
                {
                    if (runner==head)
                    {//Last item
                        isComplete=true;
                    }else
                    {
                        isComplete=false;
                    }
                    runner=runner.next;
                }
                builder.next=runner;
                builder=runner;
            }
            return dummy.next.next;
        }
        public void PrintLinkedList(Node<int> head)
        {
            StringBuilder sb =new StringBuilder();
            while (head!=null)
            {
                sb.Append($"{head.data}->");
                head=head.next;
            }
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
        }

    }
}