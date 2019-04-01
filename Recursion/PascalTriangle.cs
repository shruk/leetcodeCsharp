using System;
using System.Text;
using leetcodeCsharp.Util;
using Xunit;
using Xunit.Abstractions;

namespace leetcodeCsharp.Recursion
{
    public class PascalTriangle
    {
        private ITestOutputHelper _output;

        public PascalTriangle(ITestOutputHelper output)
        {
            _output=output;
        }
        //give ith row and jth column, return the number in PascalTriangle
        // In order to know f(i,j), need to know f(i-1,j-1) and f(i-1,j)
        // Base case: when i=0,j=0, number =1
        // Base case: when i=1;j=0,1 number =1, when i=1,j=1, number =1

        // for nth row, there are n numbers in total, so index of 0 and n-1 would be 1
        //     1
        //  1     1
        //1    2     1
        public int CalculateNumber(int i,int j)
        {   
            int result=0;
            if (j>i)
            {
                return 0;
            }

            //Base case
            if (j==0 ||j==i)
            {return 1;}
            result = CalculateNumber(i-1,j-1)+CalculateNumber(i-1,j);
            return result;

        }
        public void PrintTriangleByPos(int x,int y)
        { _output.WriteLine("");
            for (int i=0;i<=x;i++)
            { StringBuilder sb=new StringBuilder();
                for (int j=0;j<=y;j++)
                {
                    sb.Append($"{CalculateNumber(i,j)}  ");
                }
                _output.WriteLine(sb.ToString());
            }
        }

        //Array of Array, with each Array length could vary
        //rownum:(1)        1
        //rownum:(2)     1     1
        //rownum:(3)   1    2     1
        //rownum:(4) 1   3     3    1
        public int [][] GenerateTriangle(int row)
        {//Given non-negative row number
            // decalre a jagged array because we need to hold different length of arrays in an array
            // row number of array will be holded, zero based
            // Each row will have row number of elements
            // F(row) = current row + F(row -1) 
            int [][] result=new int[row][];
            for (int i=0;i<row;i++)
            {  result[i]=new int[i+1];
                for (int j=0;j<i+1;j++)
                {
                   result[i][j]= CalculateNumber(i,j);
                }
            }  
            return result;
        }
        
        public void PrintTriangle(int [][] triangle)
        { _output.WriteLine("-------Start Printing");
            for (int i=0;i<triangle.GetLength(0);i++)
            {// Get Number of arraies we have in the jagged array
                StringBuilder sb=new StringBuilder();
                for (int j=0;j<triangle[i].Length;j++)
                {
                    sb.Append($"{triangle[i][j]} ");
                }
                _output.WriteLine(sb.ToString());
            }
        }
    }

    public class PascalTriangleTest:BaseTest
    {
    private PascalTriangle _o;
    public PascalTriangleTest(ITestOutputHelper output) : base(output) => _o = new PascalTriangle(output);

    [Fact]
    public void TestName()
    {
    //Given

    //When

    //Then
    }
    [Fact]
    public void TestCalculateNumber()
    {
        Assert.Equal(1,_o.CalculateNumber(0,0));
        Assert.Equal(1,_o.CalculateNumber(1,0));
        Assert.Equal(1,_o.CalculateNumber(1,1));
        Assert.Equal(2,_o.CalculateNumber(2,1));
        _o.PrintTriangleByPos(9,3);
    }
    [Fact]
    public void TestGenerateTriangle()
    {
        _o.PrintTriangle(_o.GenerateTriangle(10));
    }
    }
}