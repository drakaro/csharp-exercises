using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;

            double r;
            Console.WriteLine("Enter a radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            if (r <= 0)
            {
                Console.WriteLine("Must enter a number greater than 0");
                Console.ReadKey();
            }

            else
            {
                double areaCircle = pi * r * r;
                Console.WriteLine("The area of a circle with radius: {0} is: {1}", r, areaCircle);
                Console.ReadLine();

                Console.ReadKey();
            }
            
        }
    }
}
