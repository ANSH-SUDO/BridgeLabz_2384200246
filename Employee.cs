using System;

public class Employee
{
    // Fields (Attributes)
    private string Name { get; set; }
    private int Id { get; set; }
    private double Salary { get; set; }

    // Constructor
    public Employee(string name, int id, int salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }
	
	// Method to display the details
	public void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee Id: " + Id);
        Console.WriteLine("Employee salary: " + Salary);
	}
	
	public static void Main(string[] args)
	{
		// Creating an object of the classname
		Employee emp = new Employee("Vanshita Khantal", 101, 50000);
		
		// Calling the method
		emp.DisplayDetails();
	}	
}