using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Video video1 = new Video(
            "How to Build a Morning Routine",
            "Jordan Lee",
            612
        );
        video1.AddComment(new Comment("Maya", "This was simple and practical."));
        video1.AddComment(new Comment("David", "I am going to try the first step tomorrow."));
        video1.AddComment(new Comment("Sofia", "The examples were especially helpful."));

        Video video2 = new Video(
            "Learning C# Classes",
            "Tech Academy",
            845
        );
        video2.AddComment(new Comment("Alex", "The abstraction examples finally make sense."));
        video2.AddComment(new Comment("Priya", "I liked the explanation of responsibilities."));
        video2.AddComment(new Comment("Noah", "The class diagram was a great visual aid."));
        video2.AddComment(new Comment("Emma", "Please make a follow-up video on inheritance."));

        Video video3 = new Video(
            "Five Tips for Better Studying",
            "Learning Lab",
            420
        );
        video3.AddComment(new Comment("Liam", "Active recall has helped me the most."));
        video3.AddComment(new Comment("Grace", "I will try studying in shorter sessions."));
        video3.AddComment(new Comment("Ethan", "Great suggestions, thank you."));

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthSeconds()} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}