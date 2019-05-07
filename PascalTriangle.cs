using System.Collections.Generic;
using Xunit;

namespace PascalTriangle{
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        
        IList<IList<int>> result=new List<IList<int>>();
        IList<int> temp=new List<int>();
        
        
        //test internet
        for (int i=0;i<numRows;i++)
        {
            IList<int> li=new List<int>();//create an empty list for each row
            for(int j=0;j<=i;j++)
            {
                if (j==0 ||j==i)
                {li.Add(1);}
                else
                {
                    li.Add(temp[j]+temp[j-1]);}
                
                
            }
            
            //save li for next round use.
            temp=li;
            result.Add(li);
        }
        
        
        return result;
        
        
    }
}

    public class PascalTriangleTest
    {
        [Fact]
        public void Test1()
        { 
        
        }
    }

}