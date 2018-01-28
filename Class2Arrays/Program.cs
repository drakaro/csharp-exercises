using System;

namespace Class2Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] {1, 1, 2, 3, 5, 8};

            foreach (int item in myArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
