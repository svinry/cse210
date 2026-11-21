using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference(
            "John",
            11,
            35
        );
        Scripture scripture = new Scripture(
            reference,
            "Jesus wept."
        );

        while (true)
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to hide words or type quit to finish:");

            string input = Console.ReadLine();
            if (input != null && input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}