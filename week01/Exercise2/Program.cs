using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradeInput);
        string letterGrade = "";

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        int remainder = gradePercentage % 10;

        string symbol = "";

        if (remainder >= 7 && !(letterGrade == "A" || letterGrade == "F"))
        {
            symbol = "+";
        }
        else if (remainder < 3 && !(letterGrade == "F"))
        {
            symbol = "-";
        }

        Console.WriteLine($"Your letter grade is {letterGrade}{symbol}.");
    
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class.");
        }
    
    }
}



