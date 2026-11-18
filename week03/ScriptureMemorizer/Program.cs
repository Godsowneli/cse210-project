
using System;

// Creativity: This program hides only words that are
// still visible, making memorization more effective.

Reference reference = new Reference("John", 3, 16);

string scriptureText =
    "For God so loved the world that he gave his only begotten Son " +
    "that whosoever believeth in him should not perish but have everlasting life.";

Scripture scripture = new Scripture(reference, scriptureText);

while (!scripture.AllWordsHidden())
{
    //   Console.Clear();

    Console.WriteLine(scripture.GetDisplayText());
    Console.WriteLine();

    Console.Write("Press Enter to hide words or type quit to exit: ");

    string input = Console.ReadLine();

    if (input != null && input.Trim().ToLower() == "quit")
    {
        Console.WriteLine("Thank you for practicing!");
        return;
    }

    scripture.HideRandomWords(3);
}

Console.Clear();

Console.WriteLine(scripture.GetDisplayText());
Console.WriteLine();
Console.WriteLine("Congratulations! All scripture words are hidden.");
