using System;
using Exercicio_02_StringBuilder.Entities;

namespace Exercicio_02_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post;

            post = new Post(
                new DateTime(2018, 06, 21, 13, 05, 44), 
                "Traveling to New Zealand", 
                "I'm going to visit this wonderful country!"
                );

            for (int i = 0; i < 12; i++)
            {
                post.AddLike();
            }

            post.AddComment(new Comment("Have a nice trip"));
            post.AddComment(new Comment("Wow that's awesome!"));

            Console.WriteLine(post);

            post = new Post(
                new DateTime(2018, 07, 28, 23, 14, 19),
                "Good night guys",
                "See you tomorrow"
                );

            for (int i = 0; i < 5; i++)
            {
                post.AddLike();
            }

            post.AddComment(new Comment("Good night"));
            post.AddComment(new Comment("May the Force be with you"));

            Console.WriteLine(post);

        }
    }
}
