using System.Text;
using leetcodeCsharp.Util;
using Xunit;
using Xunit.Abstractions;

namespace leetcodeCsharp.Recursion
{
    public class LinkedListSwap
    {
        // Given a linked list, swap every two adjacent nodes and return its head.
        //e.g.  for a list 1-> 2 -> 3 -> 4, one should return the head of list as 2 -> 1 -> 4 -> 3.
        // Try solve this problem via Recursion way. F(X), where X is each node in Linked list
        // If there is only one Node or zero Node, we do nothing, If X=2, do swap. If X=3, divid the problem to 2 + 1, so on so forth.

        private ITestOutputHelper _output;

        public LinkedListSwap(ITestOutputHelper output)
        {
            _output=output;
        }
        public Node<int> SwapLinkedList(Node<int> head)
        {
          
            Node<int> result;
            // handle first 2 nodes as a group, do swap
            // handle rest of nodes recursively
            if (head==null||head.next==null)
            {
                return head;
            }
            result=SwapNodes(head);
            result.next.next=SwapLinkedList(result.next.next);

            return result;
        }

        private Node<int> SwapNodes(Node<int> head)
        {       
            Node<int> newhead=head.next;// Copy reference to newly created reference 
            head.next=head.next.next; // Assign reference.
            newhead.next=head; // Assign reference.
            return newhead;
        }

        public void PrintLinkedList(Node<int> head)
        {
            StringBuilder sb=new StringBuilder();
            while(head!=null)
            {
               sb.Append($"{head.data.ToString()}-->"); 
               head=head.next;
            }
            _output.WriteLine(sb.ToString());
        }
    }

    public class LinkedListSwapTest:BaseTest
    {
        private LinkedListSwap _o;
        public LinkedListSwapTest(ITestOutputHelper output):base(output)
        {
            _o=new LinkedListSwap(output);
        }

        [Fact]
        public void TestSwapLinkedList()
        {

            var head=new Node<int>(8);
            var dummy=head;
            int i=0;
            while(head!=null&&i<7)
            {   i++;
                head.next=new Node<int>(i);
                head=head.next;
            }
            _o.PrintLinkedList(dummy); // Print works
            dummy=_o.SwapLinkedList(dummy);
            _o.PrintLinkedList(dummy); // Print works
        }
    }



}