using System;

namespace TextEditor
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
            Console.WriteLine("1 - Criar arquivo");
            Console.WriteLine("2 - Abrir arquivo");
            Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Criar(); break;
                case 2: Abrir(); break;
                default: Menu(); break;
            }
        }

        static void Criar()
        {
            Console.Clear();
            Console.WriteLine("Digite o seu texto abaixo (ESC para sair)");
            Console.WriteLine("---------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("Qual o nome do arquivo?");
            string name = Console.ReadLine();

            using (var file = new System.IO.StreamWriter($@"{Environment.CurrentDirectory}/{name}.txt"))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {name} salvo!");
            Console.ReadLine();
            Menu();
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o nome do arquivo?");
            string name = Console.ReadLine();

            using (var file = new System.IO.StreamReader($@"{Environment.CurrentDirectory}/{name}.txt"))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.ReadLine();
            Menu();
        }
    }
}

