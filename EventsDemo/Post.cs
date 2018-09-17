using System;

namespace EventsDemo
{
    public class Post
    {
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public Post(string content)
        {
            Content = content;
            Date = DateTime.Now;
        }
    }
}
