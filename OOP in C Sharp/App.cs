using System;
using System.Threading;

namespace StopWatch
{
    class App
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            Console.WriteLine("Start the stopwatch");
            sw.Start();
            Thread.Sleep(3000);
            sw.Stop();
            Console.WriteLine("Stop the stopwatch");

            Console.WriteLine($"The duration : {sw.GetDuration().TotalSeconds} s");
           
            
        }
    }
}
