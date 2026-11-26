
using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private string[] _prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths you are grateful for?",
        "Who have you helped this week?",
        "When have you felt the Holy Spirit this month?",
        "What are things that make you happy?",
        "What challenges have you overcome?"
    };

    public ListingActivity()
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing as many as you can.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();

        Random random = new Random();
        int promptIndex = random.Next(_prompts.Length);

        Console.WriteLine($"--- {_prompts[promptIndex]} ---");

        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();
        Console.WriteLine();

        List<string> responses = new List<string>();

        Stopwatch stopwatch = Stopwatch.StartNew();

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            Console.Write("> ");

            string response = "";

            while (stopwatch.Elapsed.TotalSeconds < duration)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine();
                        break;
                    }
                    else if (key.Key == ConsoleKey.Backspace)
                    {
                        if (response.Length > 0)
                        {
                            response = response.Substring(0, response.Length - 1);
                            Console.Write("\b \b");
                        }
                    }
                    else if (!char.IsControl(key.KeyChar))
                    {
                        response += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {responses.Count} items!");

        DisplayEndingMessage();

        while (Console.KeyAvailable)
{
    Console.ReadKey(true);
}
    }
}