/*
 Author: Isaac Martinez
 Course: COMP-003A
 Faculty: Jonathan Cruz
 Purpose: Basic console app
 */
// namespace level
namespace comp003A.lectureactivity1
{
   // class level
    internal class Program
    {
        // main level
        static void Main(string[] args)
        {
            // prompts user for input
            Console.Write("Enter your name: ");
            string username = Console.ReadLine();

            Console.WriteLine("hi " + username + ". My name is Isaac Martinez");
            Console.WriteLine("\n\nHere are 10 things about me");
            Console.WriteLine("hi");
        }
    }
}