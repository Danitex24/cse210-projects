using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding requirements:
        // I added a small scripture library and randomly select one scripture
        // each time the program runs instead of always using only one scripture.

        Random random = new Random();

        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"
            ),

            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding"
            ),

            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me"
            )
        };

        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        string input = "";

        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();

            if (input != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}