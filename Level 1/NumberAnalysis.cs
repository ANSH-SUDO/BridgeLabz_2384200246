using System;

public class NumberAnalysis
{
	public static void Main(string[] args)
    {
        // Declaring an array of 5 numbers
        int[] numbers = new int[5];

        // Taking user input for numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number {0}: ", i+1);
			numbers[i] = Convert.ToInt32(Console.ReadLine());
			if(numbers[i] < 0 || numbers[i] > int.MaxValue) {
				Console.Error.WriteLine("Invalid input. Please enter a valid integer.");
				Environment.Exit(0);
			}
        }

        // Checking each number
        foreach (int num in numbers)
        {
            // If number is positive then check even or odd
            if (num > 0)
            {
                // Checking if the number is even or odd
                if (num % 2 == 0)
                {
                    Console.WriteLine("The number {0} is positive and even.", num);
                }

                else
                {
                    Console.WriteLine("The number {0} is positive and odd.", num);
                }
            }

            // Check if the number is negative
            else if (num < 0)
            {
                Console.WriteLine("The number {0} is negative.", num);
            }

            // Check if the number is zero
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        // Comparing first and last elements
        if (numbers[0] > numbers[4])
        {
            Console.WriteLine("The first element is greater than the last element.");
        }

        else if (numbers[0] < numbers[4])
        {
            Console.WriteLine("The first element is less than the last element.");
        }
        else
        {
            Console.WriteLine("The first and last elements are equal.");
        }
    }
}