using System;

namespace EventsDemo
{
    public class PostEventArgs : EventArgs
    {
        public Post Post { get; set; }

        public PostEventArgs(Post post)
        {
            Post = post;
        }
    }
}
