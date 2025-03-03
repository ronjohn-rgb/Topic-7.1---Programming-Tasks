using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Topic_7._1___Programming_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int coin;
            int answer, points = 0;
            bool done = false;

            Console.WriteLine("Topic 7.1 - Programming Tasks");
            Console.WriteLine("");
            Console.WriteLine("Casino Game");

            while (!done) 
            { 
                coin = random.Next(1, 3);
                Console.WriteLine("Guess either 1.Heads or 2.Tails (Choose the number beside it or choose 1 to 2)");
                Console.Write("Answer: ");
                int.TryParse(Console.ReadLine(), out answer);
                
                Console.WriteLine("");
                if (answer == coin)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine("You gain one point!");
                    Console.WriteLine("Points: ");
                    Console.WriteLine(points + 1);
                    
                }
                if (answer != coin)
                {
                    Console.WriteLine("Wrong");
                    Console.WriteLine("You lose one point!");
                    Console.WriteLine("Point: ");
                    Console.WriteLine(points - 1);
                    Console.WriteLine("");
                }
            }
                    Console.WriteLine("Guess either 1.Heads or 2.Tails (Choose the number beside it or choose 1 to 2)");
                    Console.Write("Answer: ");
                    int.TryParse(Console.ReadLine(), out answer);
                    Console.WriteLine("");
            if (points == 0)
            {
                Console.WriteLine("Game over!");
                done = true;
            }
        }  
        }
    }
