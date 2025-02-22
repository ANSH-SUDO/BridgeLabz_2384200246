using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "info.txt"; // File name

        try
        {
            // Using statement ensures StreamReader is closed automatically
            using (StreamReader reader = new StreamReader(filePath))
            {
                string firstLine = reader.ReadLine(); // Read the first line
                Console.WriteLine("First line: " + firstLine);
            }
        }
        catch (IOException)
        {
            // Handle any I/O errors, including file not found
            Console.WriteLine("Error reading file.");
        }
    }
}