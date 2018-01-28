using System;

namespace AreaCircleBetter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Something to store our radius input from user
            string input;

            // something to store our parsed integer from user input
            float r;

            do
            {

                // Prompt user to input radius
                Console.Write("Enter a radius: ");

                // Read user input
                input = Console.ReadLine();

                // TryParse will return true if the string can be parsed to integer else false
                // the out keyword will assign a value to the proceeding variable inside the method being called (in this case that method is TryParse)
                /*
                 * r in the second part of this condition is valid because the comparison will be evaluated after the
                 * TryParse method has been executed and r assigned a value, or it will be skipped entirely if TryParse returns false
                */

                if (float.TryParse(input, out r) && r > 0)
                {
                    // {1:0.000} in the string.Format method tells it to print only 3 decimal places
                    Console.WriteLine(string.Format("The area of a circle with radius {0} is: {1:0.000}", r, Math.PI * r * r));
                }

                else
                {
                    Console.WriteLine("Please enter a positve number.");
                }

                // Stop the loop if the user has input either "q" or "quit"
            } while (input != "q" && input != "quit");
        }
    }
}
