using System;

namespace EventsDemo.Services
{
    public class MailService
    {
        public void OnPostCreated(object sender, PostEventArgs args)
        {
            Console.WriteLine("MailService: You have created a new post!");
            Console.WriteLine($"{args.Post.Date}\n{args.Post.Content}\n");
        }
    }
}
