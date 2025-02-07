using System;
using System.Collections.Generic;

class Book {
	private string title;
	private string author;
	
	public Book(string title, string author) {
		this.title = title;
		this.author = author;
	}
	public void display() {
		Console.WriteLine("{0} by {1}", title, author);
	}
}

class Library {
	private string name;
	List<Book> books {get; set;}
	
	public Library(string name) {
		this.name = name;
		books = new List<Book>();
	}
	public void AddBook(Book book){
		books.Add(book);
	}
	
	public void Display() {
		Console.WriteLine("Books in {0} library.", name);
		foreach(var book in books) {
			book.display();
		}
	}
}

class LibraryManagement {		
	public static void Main() {
		Book book1 = new Book("Good Book", "Good");
		Book book2 = new Book("Bad Book", "Bad");
		
		Library library1 = new Library("Oxford");
		Library library2 = new Library("Harvard");
		
		library1.AddBook(book1);
		library2.AddBook(book2);
		
		library1.Display();
		library2.Display();
		Console.ReadLine();
	}
}