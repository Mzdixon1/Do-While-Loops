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

            //Console.WriteLine("How many rows do you want in your triangle?");
            //int n = int.Parse(Console.ReadLine());
            //for (int row = 1; row <= n; row++)
            //{
            //    for (int col = 1; col <= row; col++)
            //    {
            //        Console.Write(col + " ");
            //    }
            //    Console.WriteLine();
            //}



            ////Remember that in FizzBuzz, if it is not a FizzBuzz, Fizz, or Buzz number
            ////you print the number itself.
            //Console.WriteLine("Let's Play FizzBuzz!");
            //Console.WriteLine("Please enter your FIZZ number");
            //int fizz = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter your BUZZ number");
            //int buzz = int.Parse(Console.ReadLine());
            //Console.WriteLine("What number would you like me to count to? (Pick a high one)");
            //int endNumber = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= endNumber; i++)
            //{
            //    if (i % fizz == 0 && i % buzz == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz!");
            //    }
            //    else if (i % fizz == 0)
            //    {
            //        Console.WriteLine("Fizz!");
            //    }
            //    else if (i % buzz == 0)
            //    {
            //        Console.WriteLine("Buzz!");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Add Comment Collapse          
            //Do It
            // Write a program that prints a multiplication table (5 x 5, for example) using a nested loops.
            // Create an array of your favorite movies.Print out each movie in the list, unless the move starts with a vowel. Hint: Research.startsWith()
            //Write a console application that asks the user for an integer. If that integer is evenly divisible by 3, then write “You Won!” If it isn’t, write “You Lost.” Keep asking them for a number (looping)until they win.

            int multNum = 1;
            Console.WriteLine("Enter in your first number.");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter in your second number.");
            int SecondNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= firstNumber; i++)
            {
                for (int j = 1; j <= SecondNumber; j++)
                {
                    Console.WriteLine(multNum * j + " ");

                }
                multNum += 1;
                Console.WriteLine();

            }


        }
    }
}
