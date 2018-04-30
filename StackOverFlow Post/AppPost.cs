

namespace StackOverFlow_Post
{
    class AppPost
    {
        static void Main(string[] args)
        {
            var post = new Post();
            post.UpVote();
            post.UpVote();
            post.DownVote();
           
            post.DisplayPost();
        }
    }
}
