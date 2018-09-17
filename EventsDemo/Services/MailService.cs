using System;

namespace EventsDemo.Services
{
    public class MailService
    {
        public void OnPostCreated(object sender, PostEventArgs args)
        {
            Console.WriteLine("MailService: A new post has been created!");
            Console.WriteLine($"{args.Post.Date}\n{args.Post.Content}\n");
        }
    }
}
