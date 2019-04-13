using Xunit.Abstractions;

namespace leetcodeCsharp.Util
{
    public abstract class Base{
        
       protected readonly ITestOutputHelper _output;
       public Base (ITestOutputHelper output)
       {
           _output=output;
       }
    }
}