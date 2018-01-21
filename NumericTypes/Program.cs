using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, height;
            Console.WriteLine("Find the area of a rectangle");
            Console.WriteLine("Please enter the length of the rectangle: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the height of the rectangle: ");
            height = Convert.ToInt32(Console.ReadLine());
            int area = length * height;

            Console.WriteLine("The area of your rectangle is = {0} ", area);
            Console.ReadKey();

        }
    }
}
