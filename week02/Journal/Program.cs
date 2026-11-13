
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity beyond requirements:
        // The program includes additional prompts about gratitude,
        // personal growth, and learning to encourage deeper reflection.
        
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out choice))
            {
                Console.WriteLine("Please enter a valid number.");
                choice = 0;
                continue;
            }

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry(date, prompt, response);

                theJournal.AddEntry(newEntry);

                Console.WriteLine("Your journal entry has been saved.");
            }
            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();

                theJournal.LoadFromFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();

                theJournal.SaveToFile(filename);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1 to 5.");
            }
        }
    }
}
