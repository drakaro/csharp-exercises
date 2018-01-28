using System;
using System.Linq;

namespace AliceWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = @"Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string caps = firstSentence.ToLower();
            Console.WriteLine("Please enter a word that you would like to search for: ");
            string str = Console.ReadLine();
            str = str.ToLower();
            Console.WriteLine(caps.Contains(str));

            Console.ReadKey();
            
        }
    }
}
