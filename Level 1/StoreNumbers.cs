using System;

public class StoreNumbers
{
    public static void Main(string[] args)
    {
	    // Array to store up to 10 numbers
        double[] numbers = new double[10];
		
	    // Variable to store the sum of numbers
        double total = 0.0;
		
	    // Index to track the number of elements stored
        int index = 0;

        // Infinite loop to take user inputs until a stopping condition is met
        while (true)
        {
            Console.Write("Enter a number (0 or negative to stop): ");
			double input = Convert.ToDouble(Console.ReadLine());
			if(input <= 0 || input == 10) {
				break;
			}
			else if (input > int.MaxValue)
            {
				// Handle invalid input
                Console.Error.WriteLine("Invalid input. Please enter a valid number.");
				Environment.Exit(0);
            }
				
		    // Store valid input in the array and increment index
            numbers[index] = input;
            index++;
        }
		
        // Loop to calculate the total sum of entered numbers 
        for (int i = 0; i < index; i++)
        {
            total += numbers[i];
        }
        
	    // Display all entered numbers
        Console.WriteLine("You entered the following numbers:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        
	    // Print the total sum of the numbers
        Console.WriteLine("The total sum of the numbers is: {0}", total);
    }
}