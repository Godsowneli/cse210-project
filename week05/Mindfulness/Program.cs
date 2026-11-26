
using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;

        while (choice != "4")
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();

            Console.Write("Choose an activity: ");
            choice = Console.ReadLine()?.Trim() ?? "";

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();

                breathingCount++;
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();

                reflectionCount++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();

                listingCount++;
            }
            else if (choice == "4")
            {
                // Creative feature: Track and display completed mindfulness sessions.
                // This helps users see how often they practice each activity.

                int totalActivities = breathingCount + reflectionCount + listingCount;

                Console.WriteLine();
                Console.WriteLine("========== MINDFULNESS SESSION SUMMARY ==========");
                Console.WriteLine();
                Console.WriteLine($"Breathing Activities: {breathingCount}");
                Console.WriteLine($"Reflection Activities: {reflectionCount}");
                Console.WriteLine($"Listing Activities: {listingCount}");
                Console.WriteLine();
                Console.WriteLine($"Total Activities Completed: {totalActivities}");
                Console.WriteLine();
                Console.WriteLine("Thank you for using the Mindfulness Program!");
                Console.WriteLine("Keep practicing mindfulness every day!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
            }
        }
    }
}
