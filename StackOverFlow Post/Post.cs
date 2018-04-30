using System;

namespace StackOverFlow_Post
{
    public class Post
    {
        private  int _vote = 0; 
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }

        public void UpVote()
        {
            
            _vote += 1;
        }

        public void DownVote()
        {
            _vote -= 1;
            if (_vote < 0)
                _vote = 0;
             
        }

        public void DisplayPost()
        {
            Console.WriteLine($"vote : {_vote}");
        }
        
    }
}
