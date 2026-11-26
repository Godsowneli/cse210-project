
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity", "This activity will help you relax by guiding your breathing. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            int remainingSeconds = (int)Math.Ceiling(
                (endTime - DateTime.Now).TotalSeconds
            );

            int breathingTime = Math.Min(5, remainingSeconds);

            Console.Write("Breathe in...");
            ShowCountDown(breathingTime);
            Console.WriteLine();

            if (DateTime.Now >= endTime)
            {
                break;
            }

            remainingSeconds = (int)Math.Ceiling(
                (endTime - DateTime.Now).TotalSeconds
            );

            breathingTime = Math.Min(5, remainingSeconds);

            Console.Write("Breathe out...");
            ShowCountDown(breathingTime);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
