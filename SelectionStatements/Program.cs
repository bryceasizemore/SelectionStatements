using System;
    
namespace SelectonStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number guessing game
            var r = new Random();
            var favNumber = r.Next(0, 100);
            int userInput;

            do
            {
                Console.WriteLine("pick a number from 1 - 10000");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber) 
                {
                    Console.WriteLine($"{userInput} is too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high");
                }
                else
                {
                    Console.WriteLine("you guessed it!");
                }
            
            } while (userInput != favNumber);
        }
    }
}