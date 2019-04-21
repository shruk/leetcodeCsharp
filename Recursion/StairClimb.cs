using leetcodeCsharp.Util;
using Xunit;
using Xunit.Abstractions;

namespace leetcodeCsharp.Recursion
{
     // 0 problem: Given a stair with n steps. you can choose to climb 1 or 2 steps per time. How many different ways of climbing this stairs.
     // 1.Listen, understand the problem, Sounds like a permutation to me.given a sum and elements, asking for P.
     // 2.Example, normal small case, special case(empty string/special chars?), big enough case,

    // 3.Brute force way(naive way)...pre-compute the k%length will give us index within range.
    // 4.BUD optimization. 
    //  a: look for unused info.
    //  b: Use a fresh example.
 //	  c: Solve it "incorretly" will provide negative result to think it over
 //	  d: Make time vs space tradeoff. More space may save more runtime. let's use hashtable
 //	  e: Precompute information. Sorting/compute value upfront save time in the   long run.
 //	  f: Use hash table.
 //	  g: Best conceivable runtime 
 //5.Walk Through the optimal solution found, not code yet...solidify my understanding of algorithm. Write code slowly and get a feel for the structure of the code. Know what the variables are and when they change.
 //6.Implement. Write beautiful code. a: Modularized code. write functions pretending the function is there, fill in details later if need to.
   //   b: Error checks.
   //.  c: Use classes/structs if necessary (e.g. returning object)
   //.  d: Good varaible name. it is OK to use abbreviation.
   //.  e: Just write beautiful code (need to practice)
 //7.Test. a: Conceptual test. reading and analyzing each line, does the code do what you think it does?
      //b:Weird looking code. Double check the line of code that is weird.
      //c:Hot spots. know wht things are likely to cause problem. recursive code. Integer division, Null nodes in binary trees. The start and end of iteration throught liked list.
      //d:Small test cases.
      //e:Special cases. Test against null or single element values, extreme cases, etc.
      //f:When finding bugs, analyze the bug and make correction in the best place. 
      public class StairClimb:Base
      {     
        public StairClimb(ITestOutputHelper output) : base(output)
        {
        }
        //Input: number of steps in stair
        //Output:number of ways to climb
        //Think: using recursive way to solve it
        //If n=1 , then 1 way. If n=2, then 2 ways (1,1) || 2, If n=3,then 3 ways (1,1,1) vs (1,2) vs (2,1).
        //If n=4, then 5 ways (1,1,1,1) vs (1,1,2) vs (1,2,1) vs (2,1,1) vs (2,2) 
        //if n=n, then f(n)=f(n-1)+ f(n-2)
        public int ClimbStair(int n)
          {
              if (n<=0)
              {
                  return 0;
              }
              if (n<=2)
              {
                  return n;
              }
              return ClimbStair(n-1)+ClimbStair(n-2);
          }

          // Build recursion via memoization
        public int ClimbStair_pro(int n)
          { //memo[0]=0; memo[1]=1; memo[2]=2; memo[n]=memo[n-1]+memo[n-2]
          int [] memo=new int[n+1];
          return ClimbStair_(n,memo);
          }
          
        public int ClimbStair_(int n,int [] memo)
        {
           if (n<0)
           {
             return 0;
           }
           if (n<=2)
           {
             memo[n]=n;
           }
           if (memo[n]=='\0')
           {
             memo[n]=ClimbStair_(n-1,memo)+ClimbStair_(n-2,memo);
           }
           return memo[n];
        }
      }
      public class StairClimbTest:BaseTest
      {
        private StairClimb _o;
        public StairClimbTest(ITestOutputHelper output) : base(output)
        {
            _o=new StairClimb(output);
        }
        [Fact]
        public void TestStairClimb()
        {
            Assert.Equal(0,_o.ClimbStair(0));
            Assert.Equal(1,_o.ClimbStair(1));
            Assert.Equal(2,_o.ClimbStair(2));
            Assert.Equal(3,_o.ClimbStair(3));
            Assert.Equal(5,_o.ClimbStair(4));
            Assert.Equal(_o.ClimbStair(4),_o.ClimbStair_pro(4));
        }

        [Fact]
        public override void TestPerformance()
        {
          for (int i =0;i<=100;i++)
          {
            _o.ClimbStair(i);
          }
        }
      }
}