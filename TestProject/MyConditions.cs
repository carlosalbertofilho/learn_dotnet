using System;

namespace TestProject
{
    class MyConditions
    {
        public static void Run()
        {
            Console.Clear();

            Random dice = new Random();

            var roll1 = dice.Next(1, 7);
            var roll2 = dice.Next(1, 7);
            var roll3 = dice.Next(1, 7);

            var total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            total += ifBonus(roll1, roll2, roll3);

            ifWin(total);
        }

        private static int ifBonus(int roll1, int roll2, int roll3)
        {
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples! +6 bonus to total!");
                return 6;
            }
            else if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                return 2;
            }
            else
            {
                return 0;
            }
        }

        private static void ifWin(int total)
        {
            if (total > 14)
            {
                Console.WriteLine("You win!");
            }
            else if (total < 15)
            {
                Console.WriteLine("Sorry, you lose.");
            }
            else
            {
                Console.WriteLine("Draw!");
            }
        }
    }
}