using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("PALINDROME PROGRAM");
            Console.WriteLine("Enter 0 to exit.");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter word: ");
                string input = Console.ReadLine();

              
                if (input == "0")
                {
                    Console.WriteLine("Thank you for using the program");
                    break;
                }

                
                Stack<char> charStack = new Stack<char>();
                foreach (char c in input)
                {
                    charStack.Push(c);
                }

                
                string reversedWord = "";
                while (charStack.Count > 0)
                {
                    reversedWord += charStack.Pop();
                }

                if (input.Equals(reversedWord, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("It is PALINDROME");
                }
                else
                {
                    Console.WriteLine("It is NOT PALINDROME");
                }

                Console.WriteLine();
            }
        }
    }
}
