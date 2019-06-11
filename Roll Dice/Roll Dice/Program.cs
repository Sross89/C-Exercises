using System;

namespace Roll_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                Console.WriteLine("Dice 1: " + dice1);
                Console.WriteLine("Dice 2: " + dice2 + "\n");
            }
        }
    }
}
