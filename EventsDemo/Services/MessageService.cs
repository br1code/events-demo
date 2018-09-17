using System;

namespace EventsDemo.Services
{
    public class MessageService
    {
        public void OnPostCreated(object sender, PostEventArgs args)
        {
            Console.WriteLine("MessageService: You have created a new post!");
            Console.WriteLine($"{args.Post.Date}\n{args.Post.Content}\n");
        }
    }
}
