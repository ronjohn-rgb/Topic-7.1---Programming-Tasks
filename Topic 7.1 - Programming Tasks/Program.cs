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
            int answer = 0;
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
                }


            }


            Console.WriteLine("Guess either 1.Heads or 2.Tails (Choose the number beside it or choose 1 to 2)");
            Console.Write("Answer: ");
            int.TryParse(Console.ReadLine(), out answer);
            Console.WriteLine("");
            
            
        }
        }
    }
