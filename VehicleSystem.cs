using System;
using System.Collections.Generic;

// Interface for Insurable Vehicles
public interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Abstract Vehicle class
public abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    private double rentalRate;

    // Properties with Encapsulation
    public string VehicleNumber
    {
        get { return vehicleNumber; }
        private set { vehicleNumber = value; }
    }

    public string Type
    {
        get { return type; }
        private set { type = value; }
    }

    public double RentalRate
    {
        get { return rentalRate; }
        protected set { rentalRate = value; } // Protected allows modification in subclasses
    }

    // Constructor
    public Vehicle(string vehicleNumber, string type, double rentalRate)
    {
        this.VehicleNumber = vehicleNumber;
        this.Type = type;
        this.RentalRate = rentalRate;
    }

    // Abstract method for rental cost calculation
    public abstract double CalculateRentalCost(int days);

    // Method to calculate final rental cost including insurance if applicable
    public virtual double GetTotalCost(int days)
    {
        double rentalCost = CalculateRentalCost(days);
        double insuranceCost = this is IInsurable insurable ? insurable.CalculateInsurance() : 0;
        return rentalCost + insuranceCost;
    }

    // Display Vehicle Details
    public virtual void DisplayDetails(int days)
    {
        Console.WriteLine($"Vehicle Number: {VehicleNumber}, Type: {Type}, Rental Rate per Day: {RentalRate:C}");
        Console.WriteLine($"Rental Cost for {days} days: {CalculateRentalCost(days):C}");
        
        if (this is IInsurable insurable)
            Console.WriteLine(insurable.GetInsuranceDetails());

        Console.WriteLine($"Total Cost (Rental + Insurance): {GetTotalCost(days):C}\n");
    }
}

// Car class implementing IInsurable
public class Car : Vehicle, IInsurable
{
    private string insurancePolicyNumber;
    private double insuranceRate = 0.02; // 2% of rental cost per day

    public Car(string vehicleNumber, double rentalRate, string policyNumber) 
        : base(vehicleNumber, "Car", rentalRate)
    {
        this.insurancePolicyNumber = policyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public double CalculateInsurance()
    {
        return CalculateRentalCost(1) * insuranceRate * 1.5 * 7; // Weekly insurance calculation
    }

    public string GetInsuranceDetails()
    {
        return $"Car Insurance Policy: {insurancePolicyNumber}, Insurance Cost: {CalculateInsurance():C}";
    }
}

// Bike class (No insurance applicable)
public class Bike : Vehicle
{
    public Bike(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Bike", rentalRate) { }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }
}

// Truck class implementing IInsurable
public class Truck : Vehicle, IInsurable
{
    private string insurancePolicyNumber;
    private double insuranceRate = 0.05; // 5% of rental cost per day

    public Truck(string vehicleNumber, double rentalRate, string policyNumber) 
        : base(vehicleNumber, "Truck", rentalRate)
    {
        this.insurancePolicyNumber = policyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days * 1.2; // Trucks have a 20% surcharge
    }

    public double CalculateInsurance()
    {
        return CalculateRentalCost(1) * insuranceRate * 7; // Weekly insurance calculation
    }

    public string GetInsuranceDetails()
    {
        return $"Truck Insurance Policy: {insurancePolicyNumber}, Insurance Cost: {CalculateInsurance():C}";
    }
}

// Main Program
class Program
{
    static void Main()
    {
        int rentalDays = 5; // Number of days for rental

        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("CAR-123", 50, "POL-5678"),
            new Bike("BIKE-456", 20),
            new Truck("TRUCK-789", 100, "POL-9876")
        };

        // Display vehicle details polymorphically
        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayDetails(rentalDays);
        }
    }
}
