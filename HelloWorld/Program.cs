using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Enter your name:"); //prompts for users name
            String line = Console.ReadLine(); //Gets a string from the user
            Console.Write("Hello " + line); //Tells the user hello
            Console.ReadLine(); 
        }
    }
}
