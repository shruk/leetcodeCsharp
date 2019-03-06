using System;
using System.Collections.Generic;
using Xunit;

namespace ReverseInteger
{

    public class Solution {
    
    //another normal solution without considering negative/boundries etc.
    //original solution
    public int Reverse(int x) {
        int number=0;
        List<int> li=new List<int>();
        while(x>0)
        {
            li.Add(x%10);//get right most digit by mod 10.
            x=x/10; //right shift the number by 1. eventually x equals 0...
        }
        
        //li contains numbers digit, digit*10, digit*100.....
        int time=1;
        
        for (int i=1;i<li.Count ;i++)
        {
            time=time*10;
        }
        
        foreach(int j in li)
        {
            number=number+j*time;
            time=time/10;
        }
        return number;
        
    }
    
    public int Reverse2(int x){
    	//push and pop into queue
    	bool isNeg=false;
    	if (x<0){isNeg=true;}
    	Queue<int> q=new Queue<int>();
    	while (x>0)
    	{
    		int d=x%10;
    		q.Enqueue(d);
    		x=x/10;
    	}
    	int result=0;
    	while(q.Peek()!=null)
    	{
    		result=result*10+q.Dequeue();
    	}
    	
    	if (isNeg){return (0-result);}
    	return result;
    }
}
    public class ReverseInteger
    {
        [Fact]
        public void Test1()
        {
        }
    }
}
