using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}"); // Also, we can use the Sum method from the LINQ library to calculate the sum

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}"); // Also, we can use the Average method from the LINQ library to calculate the average

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

        // Find the smallest positive number
        int minPositive = numbers[0];
        foreach (int number in numbers)
        {
            if (number > 0 && number < minPositive)
            {
                minPositive = number;
            }
        }
        Console.WriteLine($"the smallest positive number is: {minPositive}");

        // Sort the list
        // This will sort the list in ascending order, also we can use sorting algorithms like bubble sort, quick sort, etc.
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }
    }
}