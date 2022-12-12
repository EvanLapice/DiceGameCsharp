    using System;

namespace DiceGameProject
{

    class Program
    {

        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;
            int playerTotal = 0;
            int enemyTotal = 0;

            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Press any key to roll the dice: ");
                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(750);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    Console.WriteLine("...");
                    System.Threading.Thread.Sleep(500);
                    playerTotal++;
                    Console.WriteLine("You win this round!");
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    Console.WriteLine("...");
                    System.Threading.Thread.Sleep(500);
                    enemyTotal++;
                    Console.WriteLine("The enemy wins this round!");
                }
                else
                {
                    Console.WriteLine("...");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Player score: " + playerTotal);
                Console.WriteLine("Enemy score: " + enemyTotal);
                Console.WriteLine();
            }

            if(playerTotal > enemyTotal)
            {
                Console.WriteLine("You win!");
            } 
            else if(playerTotal < enemyTotal)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }

            Console.ReadKey();

        }
    }
}
