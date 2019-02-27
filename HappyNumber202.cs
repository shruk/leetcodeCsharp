using System.Collections.Generic;

namespace HappyNumber{
    public class Solution {
    public bool IsHappy(int n) {
    //find loop cycle, if cycle happens and also the result is 1, then it is a happy number
    	//else not
    	//create a hash table
    	HashSet<int> hs=new HashSet<int>();
    	while(hs.Add(n))
    	{
    	 n=getSum(n);
    	}
    	    if (n==1) return true;
            return false;       
    	}
    	
    	private int getSum(int n)
    	{
    	int temp=0;
    		while(n>0)
		    	{
			    	//get each digit
			    	int di=n%10;
			    	temp+=di*di;
			    	//move number to the right;
			    	n=n/10;
		    	}
		    return temp;
		}
}
}