using System;

class Sixteenth {
	public static void Main(string[] args) {
		int numberOfStudents = Convert.ToInt32(Console.ReadLine());
		
		int maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
		Console.WriteLine("Maximum number of handshakes are {0}", maxHandshakes);
	}
}