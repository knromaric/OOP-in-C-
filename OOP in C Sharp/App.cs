using System;
using System.Threading;

namespace OOP_in_C_Sharp
{
    class App
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            Console.WriteLine("Start first time... ");
            sw.Start();
            Thread.Sleep(3000);
            sw.Stop();
           
            Console.WriteLine($"The duration : {sw.GetDuration().TotalSeconds} s");
           
            
        }
    }
}
