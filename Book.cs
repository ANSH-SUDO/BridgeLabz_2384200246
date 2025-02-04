using System;

public class Book
{
    // Fields (Attributes)
    private string Title{ get; set; }
	private double Price{ get; set; }

    // Constructor
    public Book(string title, double price)
    {
        Title = title;
		Price = price;
    }

	// Method to display the details
	public void DisplayDetails()
    {
        Console.WriteLine("Title of the book: " + Title);
        Console.WriteLine("Price of the book: " + Price);
	}
	
	public static void Main(string[] args)
	{
		// Creating an object of the classname
		Book book = new Book("Introduction to Csharp" , 850);
		
		// Calling the method
		book.DisplayDetails();
	}	
}