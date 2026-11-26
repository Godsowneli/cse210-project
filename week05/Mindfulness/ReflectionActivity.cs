
using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private string[] _prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you showed kindness to another person.",
        "Think of a time when you overcame a challenge."
    };

    private string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was finished?",
        "What did you learn about yourself?",
        "How can you use this experience in the future?",
        "What made this experience special?",
        "What would you do differently next time?"
    };

    public ReflectionActivity()
        : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        Random random = new Random();
        int promptIndex = random.Next(_prompts.Length);

        Console.WriteLine($"--- {_prompts[promptIndex]} ---");

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        List<string> availableQuestions = new List<string>(_questions);

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            if (availableQuestions.Count == 0)
            {
                availableQuestions = new List<string>(_questions);
            }

            int questionIndex = random.Next(availableQuestions.Count);
            string question = availableQuestions[questionIndex];

            availableQuestions.RemoveAt(questionIndex);

            Console.WriteLine();
            Console.WriteLine($"> {question}");

            int remainingSeconds = (int)Math.Ceiling(
                (endTime - DateTime.Now).TotalSeconds
            );

            ShowSpinner(Math.Min(5, remainingSeconds));
        }

        DisplayEndingMessage();
    }
}
