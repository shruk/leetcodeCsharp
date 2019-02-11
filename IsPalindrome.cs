using System;
using System.Collections.Generic;
using Xunit;

namespace IsPalindrome
{

    public class Solution {//original solution
    public static bool IsPalindrome(int x) {
        int result=0;
        int temp=0;
        int y=x;
        if (x<0)
        {return false;}
        if (x==0){return true;}
        if (x%10==0)
        {return false;}
        
        while(x>0)
        { int pop=x%10;
         temp=result*10+pop;
         result=temp;
         x=x/10;
        }
        return result==y;
    }
}
    
    public class IsPalindrome
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Solution.IsPalindrome(121));
        }
    }
}
