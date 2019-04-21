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
        // virtual method may not be implemented by child class
       public virtual void TestPerformance(){}

    }
}