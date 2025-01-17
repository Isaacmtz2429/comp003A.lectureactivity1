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
            Console.WriteLine("1. I am the youngest of my family");
            Console.WriteLine("2. I ride a kawasaki ninja 650");
            Console.WriteLine("3. I am a dog Dad");
            Console.WriteLine("4. I enjoy cosplaying");
            Console.WriteLine("5. I like going to the gym and weightlifting");
            Console.WriteLine("6. I really enjoy eating and I'm not a picky eater");
            Console.WriteLine("7. For my new years resolution I decided to stop smoking and so far so good");
            Console.WriteLine("8. I enjoy looking at the clouds and the messages or images that the clouds sometimes represent");
            Console.WriteLine("9. I enjoy playing RPG video games");
            Console.WriteLine("10.In total I have 3 dogs and 2 cats and I share my birthday with one of ours dogs");
        }
    }
}