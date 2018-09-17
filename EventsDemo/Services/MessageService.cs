using System;

namespace EventsDemo.Services
{
    public class MessageService
    {
        public void OnPostCreated(object sender, PostEventArgs args)
        {
            Console.WriteLine("MessageService: A new post has been created!");
            Console.WriteLine($"{args.Post.Date}\n{args.Post.Content}\n");
        }
    }
}
