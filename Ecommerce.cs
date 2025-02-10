using System;
using System.Collections.Generic;

// Interface for Taxable Products
public interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

// Abstract Product class
public abstract class Product
{
    private int productId;
    private string name;
    private double price;

    // Properties with Encapsulation
    public int ProductId
    {
        get { return productId; }
        private set { productId = value; }
    }

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    public double Price
    {
        get { return price; }
        protected set { price = value; } // Protected allows modification in subclasses
    }

    // Constructor
    public Product(int id, string name, double price)
    {
        this.ProductId = id;
        this.Name = name;
        this.Price = price;
    }

    // Abstract method for discount calculation
    public abstract double CalculateDiscount();

    // Method to calculate final price
    public virtual double GetFinalPrice()
    {
        double discount = CalculateDiscount();
        double tax = this is ITaxable taxable ? taxable.CalculateTax() : 0;
        return Price + tax - discount;
    }

    // Display Product Details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("ID: {0}, Name: {1}, Price: {2}, Discount: {3}", ProductID, Name, Price, CalculateDiscount());
		/// Condition to check whether an item is taxable or not ///
        if (this is ITaxable taxable)
            Console.WriteLine(taxable.GetTaxDetails());
        Console.WriteLine("Final Price: {0}\n", GetFinalPrice());
    }
}

// Electronics class implementing ITaxable
public class Electronics : Product, ITaxable
{
    private double discountRate = 0.10; // 10% discount
    private double taxRate = 0.18; // 18% tax

    public Electronics(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * discountRate;
    }

    public double CalculateTax()
    {
        return Price * taxRate;
    }

    public string GetTaxDetails()
    {
        return "Electronics Tax (18%): {0}", CalculateTax();
    }
}

// Clothing class implementing ITaxable
public class Clothing : Product, ITaxable
{
    private double discountRate = 0.15; // 15% discount
    private double taxRate = 0.05; // 5% tax

    public Clothing(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * discountRate;
    }

    public double CalculateTax()
    {
        return Price * taxRate;
    }

    public string GetTaxDetails()
    {
        return "Clothing Tax (5%): {0}", CalculateTax();
    }
}

// Groceries class (No tax applicable)
public class Groceries : Product
{
    private double discountRate = 0.05; // 5% discount

    public Groceries(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * discountRate;
    }
}

// Main Program
class Program
{
    public static void Main()
    {
		/// List of products ///
        List<Product> products = new List<Product>
        {
            new Electronics(101, "Laptop", 1200),
            new Clothing(202, "Jacket", 100),
            new Groceries(303, "Milk", 5)
        };

        // Display product details polymorphically
        foreach (var product in products)
        {
            product.DisplayDetails();
        }
    }
}
