using System;

public class MultiplicationTable6To9
{
    // Creating a method to generate table from 6 to 9
    public static void Main()
    {
        // Prompt user to enter a number
        Console.Write("Enter a number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		if(number < 6 || number > 9) {
			Console.Error.WriteLine("Invalid input. Please enter a valid integer.");
			Environment.Exit(0);
		}
        
		// Define an array to store multiplication results
        int[] multiplicationResult = new int[4];

        // Loop through numbers 6 to 9 and store the results
        for (int i = 6; i <= 9; i++)
        {
            multiplicationResult[i - 6] = number * i;
        }

        // Display the multiplication table
        Console.WriteLine("Multiplication table for {0} from 6 to 9:", number);
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine("{0} * {1} = {2}", number, i, multiplicationResult[i-6]);
        }
    }
}