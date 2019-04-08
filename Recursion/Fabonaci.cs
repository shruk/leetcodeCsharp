using System;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using leetcodeCsharp.Util;

namespace cc150CSharp
{
    public class Fabonaci
    {
        private readonly ITestOutputHelper _output;

        public Fabonaci(ITestOutputHelper output)
        {
            _output=output;
        }
        public int CalculateFab(int n)
        {
            // calculate the nth element in Fabonaci sequence.
            // n=0 --> value =0; n=1 --> value =1; n=2 --> value=1; n=3 --> value=2;
            // n=4 --> value =3; n=5 --> value=5; n=n --> value=(n-1)+(n-2);
            
            if (n<2)
            {
                return n;
            }
            else
            {// O(2^n) exponential time complexity.
                return CalculateFab(n-1)+CalculateFab(n-2);
            }
        }

        public int CalculateFabPro(int n)
        {   int []memo =new int[n+1];
            return CalculateFabProRec(n,memo);
        }
        // n =0, memo[0]=0; n=1, memo[1]=1; memo[2]=memo[0]+memo[1]
        // Reduce number of time of rec Call by using temp storage
        private int CalculateFabProRec(int n,int [] memo)
        {
             if (n<2&&n>=0)
            {
                memo[n]=n;
            }
            else
            {
                if (memo[n]=='\0')
                {
                    memo[n]=CalculateFabProRec(n-1,memo)+CalculateFabProRec(n-2,memo);
                }
            }
            return memo[n];
        }
        // Print Fab sequence.
        public void PrintFab(int n)
        {
            StringBuilder sb = new StringBuilder();
            // calculate each Fab and print it outo
            for (int i=1;i<=n;i++)
            {
                sb.Append($"{CalculateFab(i)},");
            }
            _output.WriteLine(sb.ToString());
        }

    public class TestFabonaci:BaseTest
    {
        //private readonly ITestOutputHelper _output;
        private Fabonaci _o;
        public TestFabonaci(ITestOutputHelper output):base(output)
        {  
             _o=new Fabonaci(output);
        }
        [Fact]
        public void TestCalculateFab()
        {
            Assert.Equal(1,_o.CalculateFab(1));
            Assert.Equal(2,_o.CalculateFab(3));
            Assert.Equal(3,_o.CalculateFab(4));
            Assert.Equal(5,_o.CalculateFab(5));
            Assert.Equal(8,_o.CalculateFab(6));
            Assert.Equal(1,_o.CalculateFabPro(1));
            Assert.Equal(2,_o.CalculateFabPro(3));
            Assert.Equal(3,_o.CalculateFabPro(4));
            Assert.Equal(5,_o.CalculateFabPro(5));
            Assert.Equal(8,_o.CalculateFabPro(6));
            _o.PrintFab(6);
        }

        public void CalculateFabHandler()
        {
            _o.CalculateFab(10);
        }

        public void CalculateFabProHandler()
        {
            _o.CalculateFabPro(10);
        }
        [Fact]
        public void TestPerformence()
        {
            _st=new SpeedTester(CalculateFabHandler);
            _st.RunTest();
            _output.WriteLine($"Total CalFab run time: {_st.TotalRunningTime}");
            _st.method=CalculateFabProHandler;
            _st.RunTest();
            _output.WriteLine($"Total CalFab Pro run time: {_st.TotalRunningTime}");
        }

    }
    }
}