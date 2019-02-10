using System;
using System.Collections.Generic;
using Xunit;

namespace ReverseInteger
{

    public class Solution {
    
    //another normal solution without considering negative/boundries etc.
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
}
    public class ReverseInteger
    {
        [Fact]
        public void Test1()
        {
        }
    }
}
