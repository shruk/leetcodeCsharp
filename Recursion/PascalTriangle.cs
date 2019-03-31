using leetcodeCsharp.Util;
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
            //Base case
            if (j==0 ||j==i)
            {return 1;}
            result = CalculateNumber(i-1,j-1)+CalculateNumber(i-1,j);
            return result;

        }



    }

    public class TestPascalTriangle:BaseTest
    {
    private PascalTriangle _o;
    public TestPascalTriangle(ITestOutputHelper output) : base(output) => _o = new PascalTriangle(output);


    }
}