using System;
using System.Threading;
using EventsDemo.Services;

namespace EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Publisher
            Blog blog = new Blog();

            // Subscribers
            MailService mailService = new MailService();
            MessageService messageService = new MessageService();

            // Subscribing to the event of a post created
            blog.PostCreated += mailService.OnPostCreated;
            blog.PostCreated += messageService.OnPostCreated;

            blog.Post(new Post("Hello, my name is br1"));
            Thread.Sleep(1500);
            blog.Post(new Post("I want to learn C# deeply"));

            Console.ReadKey();
        }
    }
}
