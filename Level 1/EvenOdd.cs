using System;

class EvenOdd{
    public static void Main(string[] args){
        // ask user for input
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        
		if(number <= 0 || number > int.MaxValue) {
			Console.Error.WriteLine("Invalid Input.");
			Environment.Exit(0);
		}

        // Create arrays for odd and even numbers (with a maximum possible size)
        int[] oddNumbers = new int[number / 2 + 1];
        int[] evenNumbers = new int[number / 2 + 1];
        
        // Index variables for odd and even numbers
        int oddIndex = 0, evenIndex = 0;
        
        // Iterate from 1 to the entered number
        for (int i = 1; i <= number; i++){
            if (i % 2 == 0){
                evenNumbers[evenIndex] = i;
                evenIndex++;
            }
            else{
                oddNumbers[oddIndex] = i;
                oddIndex++;
            }
        }

        // Display the odd numbers array
        Console.WriteLine("\nOdd numbers:");
        for (int i = 0; i < oddIndex; i++){
            Console.Write(oddNumbers[i] + " ");
        }

        // Display the even numbers array
        Console.WriteLine("\nEven numbers:");
        for (int i = 0; i < evenIndex; i++){
            Console.Write(evenNumbers[i] + " ");
        }
    }
}
