using Xunit.Abstractions;

namespace leetcodeCsharp.Util
{
    public abstract class BaseTest
    {
       protected readonly ITestOutputHelper _output;
       protected SpeedTester _st;
       public BaseTest(ITestOutputHelper output)
       {
           _output=output;
       }

       public abstract void TestPerformance();

    }
}