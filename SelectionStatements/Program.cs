using System;
    
namespace SelectonStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number guessing game
            /*   var r = new Random();
               var favNumber = r.Next(0, 100);
               int userInput;
               var counter = 0;

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

                   counter++;

                   Console.WriteLine($"You have guessed {counter} times");

               } while (userInput != favNumber); 
           }
      */
            //switch case 
            do
            {

                Console.WriteLine("what is your favorite subject?");

                string subject = Console.ReadLine();

                switch (subject.ToLower())
                {
                    case "science":
                    case "physics":
                    case "biology":
                        Console.WriteLine("I love science!");
                        break;
                    case "calculus":
                    case "math":
                        Console.WriteLine("math is pretty awesome!");
                        break;
                    case "pe":
                    case "physical education":
                        Console.WriteLine("I dislike PE!");
                        break;
                    case "history":
                        Console.WriteLine("History is fun!");
                        break;
                    case "english":
                        Console.WriteLine("english is fun!");
                        break;
                    default:
                        Console.WriteLine("I don't know that subject");
                        break;
                }
            }while (true);
        
        
        }

    }
}