using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numList = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
            {
                Console.Write("Enter number: ");
            string numberInput = Console.ReadLine();
            number = int.Parse(numberInput);

            if (number != 0)
            {
                numList.Add(number);
            }

        } while  (number != 0);

            if (numList.Count == 0)
            {
                Console.WriteLine("No numbers were entered.");
                return;
            }

            int sum = 0;
            int largest = numList[0];

            foreach (int value in numList)
            {
                sum += value;

                if (value > largest)
                {
                    largest = value;
                }
            }

            double average = (double)sum / numList.Count;

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");
    }
}