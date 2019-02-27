namespace SwapNodesInPair{
    public class solution{
    	public ListNode SwapNodes(ListNode head)
	    {
	    		    	//test, this is a c# file
	    	//1->2->3->4
	    	//2->1->4->3
    	ListNode start=new ListNode(0);//start of listnode
    	ListNode temp;//node point to temp head
    	ListNode next;//node after head
    	ListNode next2;//node after next
    	start.next=head;//connect start
    	//start>1->2->3->4
    	temp=start;
    	
    	while(head!=null)
		    {//setups
			    	//set temp start(temp)->1->2->3->4
               if(head.next==null){break;}
		    	next=head.next;//set next 
		    	next2=next.next;//set next2 
		    	//(start&&temp)->1(head)->2(next)>3(next2)->4
		    	
		    	//do swap
		    	temp.next=next;//start->1(head&&temp)->2(next)
		    	head.next=next2;	
		    	next.next=head;
		    	
		    	//move
		    	temp=head;
		    	head=next2;
	    	}	
    	
    	return start.next;
    	
    	
    	
    	}
    
    
    }
  
}
