using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSVirtualAcademyWhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;

            //here's one while loop-- a bool

            while (displayMenu == true)
                //remember you don't need the ==true; displayMenu alone is "true" because already initialized that way
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();  //NICE!
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1, 2 or 3 (quit)");
            int result = int.Parse(Console.ReadLine());

            if (result == 1)
            {
                Console.WriteLine("One!");
                PrintNumbers();
                return true;
            }

            else if (result == 2)
            {
                Console.WriteLine("Two!");
                GuessingGame();
                return true;
            }

            else if (result == 3)
            {
                Console.WriteLine("Three!");
                return false;
            }

            else
            {
                return true;
            }
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print numbers!");
            Console.WriteLine("Type a number:");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;

            //here's another while loop: runs till it reaches a condition

            while (counter < result +1)
            {
                Console.Write($"{counter} ");
                counter++;
            }

            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");

            Random myRandom = new Random(); //Random class is a MS library already
            int randomNumber = myRandom.Next(1, 11); //(1, 11) limits choices between 1 and 10

            int guesses = 0;
            bool incorrect = true;

            //here's a do-while loop, so it runs at least once
            //until condition is met

            do
            {
                Console.WriteLine("Guess a number between 1 and 10.");
                string result = Console.ReadLine();

                if (result == randomNumber.ToString())
                {
                    incorrect = false;
                }

                else
                {
                    Console.WriteLine("Wrong! Guess again.");
                }

            }

            while (incorrect); //remember, means incorrect = false, because it was initialized that way

            Console.WriteLine( $"Correct! It too you {guesses} guesses.");
            Console.ReadLine();
        }
    }
}
