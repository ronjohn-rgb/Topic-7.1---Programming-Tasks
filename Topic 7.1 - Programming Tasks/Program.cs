using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Topic_7._1___Programming_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Topic 7.1 - Programming Tasks");
            Console.WriteLine("");
            bool correct= false;
            Console.WriteLine("Casino Game");
            Console.WriteLine("Guess either 1.Heads or 2.Tails (Choose the number beside it or choose 1 to 2)");
            Random random = new Random();
            int coin;
            coin = random.Next(1, 3);
            Console.Write("Answer: ");
            int answer = 0;

            Console.WriteLine("");
            while (correct!)
            {
                 int.TryParse(Console.ReadLine(), out answer);

                if (answer == coin)
                {
                    Console.WriteLine("Correct!");
                    while (answer  != coin)
                    {

                    }
                }
                else 
                {
                    Console.WriteLine("Wrong! Type your answer again!");

                    Console.WriteLine("Answer: ");
                    Console.WriteLine();
                }
            }
        }
    }
}
