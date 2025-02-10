using System;
using System.Collections.Generic;

abstract class Employee {
	
	private int employeeId;
	private string name;
	protected double baseSalary;
	
	public Employee(int employeeId, string name, double baseSalary) {
		this.employeeId = employeeId;
		this.name = name;
		this.baseSalary = baseSalary;
	}
	
	public abstract double CalculateSalary();
	
	public virtual void DisplayDetails() {
		Console.WriteLine("Id: {0}, Name: {1}, Salary: {2}, Total Salary: {3}", employeeId, name, baseSalary, CalculateSalary().ToString("F2"));
	}
}

interface IDepartment {
	void AssignDepartment(string department);
	void GetDepartmantDetails();
}

/// Full Time Employee class implementing interface and abstract class ///
class FullTimeEmployee : Employee, IDepartment {
	
	private string department;
	private double bonus;
	
	public FullTimeEmployee(int employeeId, string name, double baseSalary, double bonus):base(employeeId, name, baseSalary){
		this.bonus = bonus;
	}
	
	public void AssignDepartment(string dept) {
		department = dept;
	}
	
	public void GetDepartmantDetails() {
		Console.WriteLine("Department: {0}", department);
	}
	
	public override double CalculateSalary() {
		return baseSalary + bonus;
	}
	
	public override void DisplayDetails() {
		Console.WriteLine("--Full Time Employee--");
		base.DisplayDetails();
		GetDepartmantDetails();
	}
}

/// Part Time Employee class implementing interface and abstract class ///
class PartTimeEmployee : Employee, IDepartment {
	private int workHours;
	private string department;
	private double hourlyRate;
	
	public PartTimeEmployee(int employeeId, string name, int workHours, double hourlyRate):base(employeeId, name, 0) {
		this.workHours = workHours;
		this.hourlyRate = hourlyRate;
	}
	
	public void AssignDepartment(string dept) {
		department = dept;
	}
	
	public void GetDepartmantDetails() {
		Console.WriteLine("Department: {0}", department);
	}
	
	public override double CalculateSalary() {
		return workHours * hourlyRate;
	}
	
	public override void DisplayDetails() {
		Console.WriteLine("--Part Time Employee--");
		base.DisplayDetails();
		GetDepartmantDetails();
	}
}



class Program {
	public static void Main() {
		
		/// List of employees ///
		List<Employee> employee = new List<Employee> {
			new FullTimeEmployee(234, "David", 55000, 5000),
			new PartTimeEmployee(234, "Ramesh", 20, 120)
		};
		
		/// Assigning Departments ///
		((IDepartment)employee[0]).AssignDepartment("HR");
		((IDepartment)employee[1]).AssignDepartment("Developer");
		
		/// Displaying employee details polymorphically ///
		foreach(var emp in employee) {
			emp.DisplayDetails();
			Console.WriteLine();
		}
	}
}