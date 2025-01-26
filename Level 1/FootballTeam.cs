using System;

public class FootballTeam
{
	public static void Main(string[] args)
    {
        // Declare an array to store the heights of 11 players
        double[] heights = new double[11];
        double sum = 0.0;

        // Get user input for each player's height
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write("Enter the height of player {0}: ", i+1);
			double height = Convert.ToDouble(Console.ReadLine());
			if(height < 100.0 || height > 300.0) {
				Console.Error.WriteLine("Invalid input. Please enter a valid height.");
				Environment.Exit(0);
			}
            heights[i] = height;
            sum += height; // Add height to the sum
        }

        // Calculate the mean height
        double meanHeight = sum / heights.Length;

        // Display the mean height of the football team
        Console.WriteLine("The mean height of the football team is: {0}", meanHeight);
    }
}