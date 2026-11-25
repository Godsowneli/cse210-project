using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project."); 
       
        // Create the first video
        Video video1 = new Video(
            "Learning C# for Beginners", "Code Academy", 600);

        video1.AddComment(new Comment("John", "This tutorial is very helpful."));
        video1.AddComment(new Comment("Mary", "I learned something new today."));
        video1.AddComment(new Comment("David", "Please make more tutorials."));

        // Create the second video
        Video video2 = new Video(
            "How to Build a Website", "Web Developer", 900);

        video2.AddComment(new Comment("Grace", "Great explanation!"));
        video2.AddComment(new Comment("Peter", "Very easy to understand."));
        video2.AddComment(new Comment("James", "Thanks for sharing."));

        // Create the third video
        Video video3 = new Video(
            "Introduction to Python", "Programming World", 750);

        video3.AddComment(new Comment("Sarah", "Python is interesting."));
        video3.AddComment(new Comment("Michael", "I enjoyed this lesson."));
        video3.AddComment(new Comment("Daniel", "Excellent teaching."));

        // Create the fourth video
        Video video4 = new Video(
            "Understanding Object-Oriented Programming",
            "Tech Learning", 1200);

        video4.AddComment(new Comment("Esther", "This helped me understand classes."));
        video4.AddComment(new Comment("Paul", "Very useful content."));
        video4.AddComment(new Comment("Ruth", "I want to learn more."));

        // Put all videos into a list
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display every video and its comments
        foreach (Video video in videos)
        {
            Console.WriteLine("==============================");
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}