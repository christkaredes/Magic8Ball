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
        {   // Introduction
            Console.WriteLine("Welcome to my domain, mortal. I am Azoth, Seer of All Realms."); 
            Task.Delay(TimeSpan.FromSeconds(2)).Wait();
            Console.WriteLine("Allow me to prepare your session");
            Console.Write("."); Task.Delay(TimeSpan.FromSeconds(1)).Wait();
            Console.Write("."); Task.Delay(TimeSpan.FromSeconds(.5)).Wait();
            Console.Write("."); Task.Delay(TimeSpan.FromSeconds(.5)).Wait();
            Console.Write("."); Task.Delay(TimeSpan.FromSeconds(.5)).Wait();
            Console.Write("."); Task.Delay(TimeSpan.FromSeconds(.5)).Wait();
            Console.WriteLine();

            Magic8Ball Seer = new Magic8Ball();
            // Azoth's answers are set now
            Seer.SeerAnswers();
            string _question = "";
            string _userInput = "";

            do
            {
                // User's selections are laid out
                Console.WriteLine();
                Console.WriteLine("Choose...");        Task.Delay(TimeSpan.FromSeconds(.1)).Wait();
                Console.WriteLine("(S)hake the Ball"); Task.Delay(TimeSpan.FromSeconds(.1)).Wait();
                Console.WriteLine("(A)sk a Question"); Task.Delay(TimeSpan.FromSeconds(.1)).Wait();
                Console.WriteLine("(G)et the Answer"); Task.Delay(TimeSpan.FromSeconds(.1)).Wait();
                Console.WriteLine("(E)xit Azoth's chambers");
                Console.WriteLine("Enter S, A , G, or E:");
                _userInput = Console.ReadLine();
                // Conditions for the letters that are typed (s,a,g,e)
                if (_userInput.ToLower() == "s")
                {
                    Console.WriteLine();
                    Seer.Shake(); // Randomly selects an answer
                    Console.WriteLine("The spirits are are retrieving your answer.");
                    Task.Delay(TimeSpan.FromSeconds(1.5)).Wait();
                    Console.WriteLine("They are ready"); // Feedback for saving the answer
                    Task.Delay(TimeSpan.FromSeconds(.5)).Wait();
                }
                else if (_userInput.ToLower() == "a")
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("What is your question?");
                    Console.ForegroundColor = ConsoleColor.White;
                    _question = Console.ReadLine(); // saves the question to the variable.
                    Task.Delay(TimeSpan.FromSeconds(1)).Wait();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The spirits have your answer."); // Feedback for saving the answer
                    Console.ForegroundColor = ConsoleColor.White;
                    Task.Delay(TimeSpan.FromSeconds(.5)).Wait();

                }
                else if (_userInput.ToLower() == "g")
                {
                    if (_question.Length == 0) // If there was no question asked, then the user
                                               // is brought back to the menu
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You need to ask me a question first...");
                        Task.Delay(TimeSpan.FromSeconds(1)).Wait();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Task.Delay(TimeSpan.FromSeconds(.5)).Wait();
                        string _answer = Seer.GetAnswer(); // Returns the answer by calling the getter
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The answer to your question " + "'" + _question + "'" + " is " + "'" + _answer + "'");
                        Console.ForegroundColor = ConsoleColor.White;
                        Task.Delay(TimeSpan.FromSeconds(1.5)).Wait();
                    }
                    
                }
                else if (_userInput.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed; // Spookiness
                    Console.WriteLine("Are you afraid, mortal? Speak.");
                    Task.Delay(TimeSpan.FromSeconds(2)).Wait();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (_userInput.ToLower() == "e")
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkRed; // Even more spookiness
                    Console.WriteLine("Then leave...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Task.Delay(TimeSpan.FromSeconds(2.5)).Wait();
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkRed; // And more spookiness.
                    Console.WriteLine("Stop wasting my time, mortal.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Task.Delay(TimeSpan.FromSeconds(2)).Wait();
                }
            }
            while (_userInput.ToLower() != "e"); // Until 'e' is struck, the player remains in Azoth's domain
        }
    }
}