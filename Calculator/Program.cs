using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("Opção: ");
            short option = short.Parse(tryReadsShort());

            switch(option)
            {
                case 1: Add(); break;
                case 2: Sub(); break;
                case 3: Mult(); break;
                case 4: Div(); break;
                case 5: Environment.Exit(0); break;
                default: ShowError(); break;
            }
        }

        static void Add()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(tryReadsFloat());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(tryReadsFloat());

            Console.WriteLine("O resultado de "+v1+" + "+v2+" é "+(v1+v2));
        }

        static void Sub()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(tryReadsFloat());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(tryReadsFloat());

            Console.WriteLine("O resultado de "+v1+" - "+v2+" é "+(v1-v2));
        }

        static void Mult()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(tryReadsFloat());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(tryReadsFloat());

            Console.WriteLine("O resultado de "+v1+" * "+v2+" é "+(v1*v2));
        }

        static void Div()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(tryReadsFloat());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(tryReadsFloat());

            Console.WriteLine("O resultado de "+v1+" / "+v2+" é "+(v1/v2));
        }

        static void ShowError()
        {
            Console.Clear();
            Console.WriteLine("Opção inválida!");
            Menu();
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

        static string tryReadsFloat()
        {
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Nenhuma entrada detectada, tente novamente: ");
                return tryReadsFloat();
            }
            else if (!float.TryParse(input, out float result))
            {
                Console.WriteLine("Entrada inválida, tente novamente: ");
                return tryReadsFloat();
            }
            else
            {
                return input;
            }
        }
    }
}