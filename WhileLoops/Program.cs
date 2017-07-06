using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //// While loop is used when you want a chunk of code to run only if a condition is met first.
            ////While something is TRUE, do this thing.

            //Console.Writeline("What is your first Name?");
            //string firstName = Console.ReadLine();
            //while(firstName.ToUpper() == "Daniel")
            //   {
            //   Console.WriteLine("Dude your amazing");
            //   }

            //Console.WriteLine("Do you want to play the game? YES/NO");
            //string playAgain = Console.ReadLine();
            //while (playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //   playAgain = Console.ReadLine();
            //}

            //A DO-While Loop is similar to a while loop, however,
            //The Do-While loop is used when you want a chunk of code to run.
            //At LEAST ONCE, but repeat only if the while condition is met.

            // The Structure of a Do-While loop looks ike this:
            //do
            //{
            //Do Something
            //}
            //while(condition)

            //do
            //{
            //    Console.WriteLine("Welcome to my game!");
            //    //lets pretend the code for the game is here
            //    Console.WriteLine("Great game!!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //}
            //while (playAgain == "YES");

            //Ask the user for the class (in school) they would like to add to there GPA Calculation.
            //Ask the user if they have another class they would like to add to there GPA Calculation.
            //Using a DO-While LOOP, repeat the code if the user says "YES"
            string addClass;
            do
            {
                Console.WriteLine("What class would you like to add to your GPA Calculation?");
                 addClass = Console.ReadLine();
                Console.WriteLine("Do you have another class you would like to add to your GPA Calculation? YES/NO");
            }
            while (addClass == "Yes");
                   
        }
    }
}
