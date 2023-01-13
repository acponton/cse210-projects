using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int number = 1;
        
        while (number != 0)
        {
            Console.WriteLine();
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
            
        }

        int total = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
      
        
    }
}