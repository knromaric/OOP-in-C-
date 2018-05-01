using System;

namespace WorkFlow_Engine
{
    public class VideoActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video....");
        }
    }
}
