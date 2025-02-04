using System;

class Fizzbuzz
{
    public static void Main(string[] args)
	{
        // Take user input for the number
        Console.WriteLine("Enter a positive integer:");
        int number = Convert.ToInt32(Console.ReadLine());
		
		if(number < 0 || number > int.MaxValue) {
			Console.Error.WriteLine("Please enter a valid positive integer.");
			Environment.Exit(0);
		}
		
        // Create a string array to store results
        string[] results = new string[number + 1];  

        // Loop from 0 to the entered number
        for (int i = 0; i <= number; i++){
            // Check for multiples of 3, 5, or both
            if (i % 3 == 0 && i % 5 == 0){
                results[i] = "FizzBuzz";
            }
            else if (i % 3 == 0){
                results[i] = "Fizz";
            }
            else if (i % 5 == 0){
                results[i] = "Buzz";
            }
            else{
				// For other numbers, save the number itself
                results[i] = i.ToString();  
            }
        }

        // Display the results in the format "Position X = value"
        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine("Position"+(i)+" = "+(results[i])+"");
        }
    }
}
