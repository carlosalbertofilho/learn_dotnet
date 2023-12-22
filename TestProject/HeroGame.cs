using System;
using System.Runtime.CompilerServices;

namespace TestProject
{
    class HeroGame
    {
        public int heroHealth { get; private set; } = 10;
        public int monsterHealth { get; private set; } = 10;

        public static void Run()
        {
            var game = new HeroGame();
            Console.Clear();
            do
            {
                game.heroAttack();
                game.monsterAttack();
            } while (game.isNotOver());
        }

        private void heroAttack()
        {
            if (monsterHealth <= 0 || heroHealth <= 0)
                return;

            var attack = new Random().Next(1, 10);
            monsterHealth -= attack;
            var message = $"Monster was damaged and lost {attack}";
            message += $" health and now has {monsterHealth} health.";
            Console.WriteLine(message);
        }

        private void monsterAttack()
        {
            if (heroHealth <= 0 || monsterHealth <= 0 )
                return;

            var attack = new Random().Next(1, 10);
            heroHealth -= attack;
            var message = $"Hero was damaged and lost {attack}";
            message += $" health and now has {heroHealth} health.";
            Console.WriteLine(message);
        }

        private bool isNotOver()
        {
            var heroIsDead = heroHealth <= 0;
            var monsterIsDead = monsterHealth <= 0;
            var message = heroIsDead
                ? "Monster wins!"
                : monsterIsDead
                    ? "Hero wins!"
                    : "Fight continues!";

            Console.WriteLine(message);
            return !heroIsDead && !monsterIsDead;
        }
    }
}
