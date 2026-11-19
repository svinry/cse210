using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Fraction five = new Fraction(5);
        Fraction threeFourths = new Fraction(6, 7);
        Fraction oneThird = new Fraction(1, 3);

        threeFourths.SetTop(3);
        threeFourths.SetBottom(4);
        Console.WriteLine($"Getter/setter check: {threeFourths.GetTop()}/{threeFourths.GetBottom()}");

        DisplayFraction(one);
        DisplayFraction(five);
        DisplayFraction(threeFourths);
        DisplayFraction(oneThird);
    }

    static void DisplayFraction(Fraction fraction)
    {
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}