using Magic8Ball_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the Magic 8 Ball!");
            Task.Delay(TimeSpan.FromSeconds(2)).Wait();

            Magic8Ball Toy = new Magic8Ball();
            Toy.RegularAnswers();
            string _question = "";
            string _userInput = "";

            do
            {
                Console.WriteLine();
                Console.WriteLine("Please select");    Task.Delay(TimeSpan.FromSeconds(.1)).Wait();
                Console.WriteLine("(S)hake the Ball"); Task.Delay(TimeSpan.FromSeconds(.1)).Wait();
                Console.WriteLine("(A)sk a Question"); Task.Delay(TimeSpan.FromSeconds(.1)).Wait();
                Console.WriteLine("(G)et the Answer"); Task.Delay(TimeSpan.FromSeconds(.1)).Wait();
                Console.WriteLine("(E)xit Game");      Task.Delay(TimeSpan.FromSeconds(.1)).Wait();
                Console.WriteLine("Enter S, A , G, or E:");
                _userInput = Console.ReadLine();

                if (_userInput.ToLower() == "s")
                {
                    Toy.Shake(); // Randomly selects an answer
                    Console.WriteLine();
                    Console.WriteLine("Getting your answer...");
                    Task.Delay(TimeSpan.FromSeconds(1)).Wait();
                    Console.WriteLine("Your answer is ready!"); // Feedback for saving the answer
                    Task.Delay(TimeSpan.FromSeconds(.5)).Wait();
                }
                else if (_userInput.ToLower() == "a")
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ask away!");
                    Console.ForegroundColor = ConsoleColor.White;
                    _question = Console.ReadLine(); // Saves the question to the variable.
                    Task.Delay(TimeSpan.FromSeconds(1)).Wait();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Your answer has now been stored!"); // Feedback for saving the answer
                    Console.ForegroundColor = ConsoleColor.White;
                    Task.Delay(TimeSpan.FromSeconds(.5)).Wait();
                }
                else if (_userInput.ToLower() == "g")
                {
                    if (_question.Length == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You need to ask a question first, silly!");
                        Task.Delay(TimeSpan.FromSeconds(1)).Wait();
                    }
                    else
                    {
                        Task.Delay(TimeSpan.FromSeconds(.5)).Wait();
                        String _answer = Toy.GetAnswer(); // Returns the answer by calling the getter
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The answer to your question " + "'" + _question + "'" + " is " + "'" + _answer + "'");
                        Console.ForegroundColor = ConsoleColor.White;
                        Task.Delay(TimeSpan.FromSeconds(1)).Wait();
                    }
                }
                else if (_userInput.ToLower() == "e")
                {
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                    Task.Delay(TimeSpan.FromSeconds(2)).Wait();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please type 'S','A','G', or 'E'.");
                    Task.Delay(TimeSpan.FromSeconds(2)).Wait();
                }
            }
            while (_userInput.ToLower() != "e"); // Until 'e' is struck, the program is still open
        }
    }
}