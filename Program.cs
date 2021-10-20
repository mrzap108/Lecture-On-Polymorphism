using System;

namespace UsingStudioCodePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //METHOD OVERLOADING - EXAMPLE 1
            Displays displays = new Displays();
            displays.print(45);
            displays.print(34.11);
            displays.print("The quick brown fox");

            //METHOD OVERLOADING -EXAMPLE 2
            Operations computes = new Operations();
            double sum = 0;
            int sum1 = 0;
            sum = computes.ComputeSum(35.11, 65.75);
            Console.WriteLine("The sum is {0}", sum);
            sum = computes.ComputeSum(35.11, 65.75, -5.5);
            Console.WriteLine("The sum is {0}", sum);
            sum1 = computes.ComputeSum(4,7);
            Console.WriteLine("The sum is {0}", sum1);

            //RUNTIME POLYMORPHISM - METHOD OVERRIDING
            RunTimePoly testRunTime = new RunTimePoly();
            testRunTime.forRunTimeDemoShow();
        }
    }
}
