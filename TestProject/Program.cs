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
            Console.WriteLine("3 - MyData");
            Console.WriteLine("4 - MyConditions");
            Console.WriteLine("5 - MySybscription");
            Console.WriteLine("6 - MyMatrix");
            Console.WriteLine("7 - MyProjetoGuiado2");
            Console.WriteLine("8 - MyDecision");
            Console.WriteLine("0 - Sair");

            short option = short.Parse(tryReadsShort());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: MyRandom.RollDice();; break;
                case 2: MyString.MyCompare(); break;
                case 3: MyData.Show(); break;
                case 4: MyConditions.Run(); break;
                case 5: MySybscription.Run(); break;
                case 6: MyMatrix.Run(); break;
                case 7: MyProjetoGuiado2.Run(); break;
                case 8: MyDecision.Run(); break;
                default: Menu(); break;
            }
        }

         static string tryReadsShort()
        {
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Nenhuma entrada detectada, tente novamente: ");
                return tryReadsShort();
            }
            else if (!short.TryParse(input, out short result))
            {
                Console.WriteLine("Entrada inválida, tente novamente: ");
                return tryReadsShort();
            }
            else
            {
                return input;
            }
        }
    }
}