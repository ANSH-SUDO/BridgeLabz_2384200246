using System;

public class VotingEligibility
{
	public static void Main(string[] args)
    {
        // Declaring an array of 10 integers to store student ages
        int[] studentAges = new int[10];

        // Taking user input for student ages
        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.Write("Enter the age of student {0}: ", i+1);
			studentAges[i] = Convert.ToInt32(Console.ReadLine());
			if(studentAges[i] < 0 || studentAges[i] > 120) {
				Console.Error.WriteLine("Invalid input. Please enter a valid number.");
				Environment.Exit(0);
			}
		}
        // Checking voting eligibility
        foreach (int age in studentAges)
        {
            // Check if the age is greater than or equal to 18
            if (age >= 18)
            {
                Console.WriteLine("The student with the age {0} can vote.", age);
            }
            else
            {
                Console.WriteLine("The student with the age {0} cannot vote.", age);
            }
        }
    }
}