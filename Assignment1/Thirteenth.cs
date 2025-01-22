using System;

class Thirteenth {
	public double findLength(double perimeter) {
		return perimeter/4;
	}
	
	public static void Main(string[] args) {
		double perimeter = Convert.ToDouble(Console.ReadLine());
		
		Thirteenth th = new Thirteenth();
		double result = th.findLength(perimeter);
		
		Console.WriteLine("The length of the side is {0} whose perimeter is {1}", result, perimeter);
	}
}