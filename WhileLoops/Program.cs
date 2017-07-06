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

            //string addClass;
            //do
            //{
            //    Console.WriteLine("What class would you like to add to your GPA Calculation?");
            //     addClass = Console.ReadLine().ToLower();
            //    Console.WriteLine("Do you have another class you would like to add to your GPA Calculation? YES/NO");
            //}
            //while (addClass == "Yes");

            //NESTED LOOPS 
            //Loop inside of another loop. 
            //The inner loop is executed more times than the outer loop
            //Real Life Example - Clock

            //Creat a nested loop structure that prints:
            //1234
            //1234

            //for(int rows = 1; rows <= 2; rows++)
            //{
            //    for(int columns = 1; columns <= 4; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}


            // Print a Triangle
            //Outer loop will go line by line
            //The inner lop will go over different elements in the line.
            //Result:
            //1
            //1 2
            // 1 2 3
            // 1 2 3 4


            //int num, space;

            //while (true)
            //{
            //    Console.Write("Enter a number between 1 to 4 : ");

            //    num = Convert.ToInt32(Console.ReadLine());

            //    space = num - 1;

            //    for (int i = 1; i <= num; i++)
            //    {
            //        for (space = 1; space <= (num - i); space++)
            //        {
            //            Console.Write(" ");
            //        }

            //        for (int j = 1; j <= i; j++)
            //        {
            //            Console.Write(j);
            //        }

            //        for (int k = (i - 1); k >= 1; k--)
            //        {
            //            Console.Write(k);
            //        }

            //        Console.WriteLine();
            //    }
            //}

            Console.WriteLine("How many rows do you want in your triangle?");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                Console.Write(ConsoleColor = "");

            }
            Console.WriteLine();
        }
    }
}
