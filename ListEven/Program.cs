using System;
using System.Collections.Generic;

namespace ListEven
{
    class Program
    {
        static int SumOfEvens(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                if ( number % 2 == 0 )
                {
                    result += number;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<string> numbers = new List<string>();
            string number;

            Console.WriteLine("To get the sum of all the even numbers inputted");
            Console.WriteLine("Enter a number: When you have finished entering all the numbers you want to be evaluated, press Enter.");
            do
            {
                number = Console.ReadLine();
                if (number != "")
                {
                    numbers.Add(number);
                }
            } while (number != "");

            int numbersStr = Int32.Parse(numbers);
            int result = SumOfEvens(numbers);
            Console.WriteLine("The sum of even integers is: {0}", result);

            Console.ReadKey();
        }
    }
}
