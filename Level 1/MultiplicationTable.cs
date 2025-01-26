using System;

public class MultiplicationTable
{
	public static void Main(string[] args)
    {
	  // Taking user input to generate table of a number
        Console.Write("Enter a number to generate its multiplication table: ");
		int number = Convert.ToInt32(Console.ReadLine());
		if(number < 0 || number > int.MaxValue) {
			Console.Error.WriteLine("Invalid input. Please enter a valid integer.");
			Environment.Exit(0);
		}
			
		// Calling the method
        GenerateMultiplicationTable(number);
    }
	
	// Creating a method to generate table of a number
	public static void GenerateMultiplicationTable(int number)
      {
	  // Declaring an array of 10 integers
        int[] table = new int[10];

        // Storing multiplication table
        for (int i = 1; i <= 10; i++)
        {
            table[i - 1] = number * i;
        }

        // Displaying the multiplication table
        for (int i = 0; i < table.Length; i++)
        {
            Console.WriteLine("{0} * {1} = {2}", number, (i+1), table[i]);
        }
    }
}