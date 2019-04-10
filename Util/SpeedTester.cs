//http://www.vcskicks.com/
using System;
using System.Diagnostics;

namespace leetcodeCsharp.Util
{

    public delegate void MethodHandler();
    public delegate void MethodHandlerInc(int input);

    // SpeedTester is constructed by a delegate method that user pass in a method
    // And then the speedTester has a RunTest method to run a default number of times for this method,
    // And then the totalRunningTime and averageRunningTime can be recorded.
    public class SpeedTester
    {
        private int totalRunningTime;
        private double averageRunningTime;
        public MethodHandler method;
        public MethodHandlerInc methodInc;

        public int TotalRunningTime
        {
            get { return totalRunningTime; }
        }
        public double AverageRunningTime
        {
            get { return averageRunningTime; }
        }
        public SpeedTester()
        {

        }
        public SpeedTester(MethodHandler methodToTest)
        {
            this.method = methodToTest;
        }


        public void RunTest()
        {
            RunTest(100000); //default 10,000 trials
        }

        public void RunTest(int trials)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();
            for (int i = 0; i < trials; i++)
            {
                method.Invoke(); //run the method
            }
            watch.Stop();

            totalRunningTime = (int)watch.ElapsedMilliseconds; //total milliseconds
            averageRunningTime = (double)TotalRunningTime / trials; //total time over number of trials
        }

        //Incremental input test
        //Passing type into function
        public void RunImcrementalTest<T>(T type)
        {
            Stopwatch watch=new Stopwatch();
            watch.Start();

            //Randomly generate number of inputs
            for(int i=0;i<=1000;i++)
            {
                //Generate i number of inputs
               // this.methodInc(i).
            }
        }
    }
}
