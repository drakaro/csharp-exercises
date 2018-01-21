using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles, gallon;
            Console.WriteLine("To Calculate your miles per gallon");
            Console.WriteLine("Please enter how amny miles you've driven: ");
            miles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PLease enter how many gallons of gas you've used: ");
            gallon = Convert.ToInt32(Console.ReadLine());
            int mpg = miles / gallon;

            Console.WriteLine("This is your miles per gallon: {0}", mpg);
            Console.ReadKey();
        }
    }
}
