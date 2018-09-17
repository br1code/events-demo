using System;
using System.Collections.Generic;
using System.Threading;

namespace EventsDemo
{
    public class Blog
    {
        private List<Post> posts;

        public event EventHandler<PostEventArgs> PostCreated;

        public Blog()
        {
            posts = new List<Post>();
        }

        public void Post(Post post)
        {
            Console.WriteLine("New post created\n");
            posts.Add(post);
            Thread.Sleep(3000);

            // Raise the event to the subscribers and pass a reference of the post
            OnPostCreated(post);
        }

        private void OnPostCreated(Post post)
        {
            // Check if there is any subscriber, then invoke
            PostCreated?.Invoke(this, new PostEventArgs(post));
        }
    }
}
