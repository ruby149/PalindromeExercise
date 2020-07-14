using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            WordSmith newOne = new WordSmith();
            string reverse = newOne.IsApalindrom("ruby");
            Console.WriteLine($"{reverse}");
        }
    }
}
