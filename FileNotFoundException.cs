using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "Data.txt";

            try
            {
                // Read and print file contents if it exists
                string content = File.ReadAllText(file);
                Console.WriteLine("File Contents:\n" + content);
            }
            catch (FileNotFoundException)
            {
                // Handle the file not found exception
                Console.WriteLine("File not found.");
            }
            catch (IOException ex)
            {
                // Handle other I/O exceptions
                Console.WriteLine("An error occurred while reading the file: " + ex.Message);
            }
        }
    }
}