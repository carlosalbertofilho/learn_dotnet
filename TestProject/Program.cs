using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - MyRandom");
            Console.WriteLine("2 - MyString");
            Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: MyRandom.RollDice();; break;
                case 2: MyString.MyInterpolation(); break;
                default: Menu(); break;
            }
        }
    }
}