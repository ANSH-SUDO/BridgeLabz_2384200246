using System;

public class Circle
{
    // Fields (Attributes)
    private double Radius{ get; set; }

    // Constructor
    public Circle(double radius)
    {
        Radius = radius;
    }
	
	// Method to calculate area
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    // Method to calculate circumference
    public double CalculateCircumference()
    {
        return 2 * Math.PI * Radius;
    }

	// Method tho display the details
	public void DisplayDetails()
    {
        Console.WriteLine("Radius: " + Radius);
        Console.WriteLine("Area: " + CalculateArea().ToString("F2"));
        Console.WriteLine("Circumference: " + CalculateCircumference().ToString("F2"));
	}
	
	public static void Main(string[] args)
	{
		// Creating an object of the classname
		Circle circle = new Circle(5.5);
		
		// Calling the method
		circle.DisplayDetails();
	}	
}