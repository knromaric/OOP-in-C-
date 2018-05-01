using System;

namespace WorkFlow_Engine
{
    public class EmailActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending Email to the owner of the video...");
        }
    }
}
