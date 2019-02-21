using System.Collections.Generic;
using Xunit;

namespace PascalTriangle2{
public class Solution {
    public IList<int> GetRow(int rowIndex) {
        
        IList<IList<int>> result=new List<IList<int>>();
        IList<int> temp=new List<int>();
        
        
        
        for (int i=0;i<=rowIndex;i++)
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
        
        
        return result[rowIndex];
        
        
    }
}

    public class PascalTriangle2Test
    {
        [Fact]
        public void Test1()
        { 
        
        }
    }

}