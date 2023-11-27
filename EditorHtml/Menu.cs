using System;

namespace EditorHtml
{
    class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();
            WriteInput();
        }

        static void DrawScreen()
        {
            int windowWidth = Console.WindowWidth;
            int windowHeight = Console.WindowHeight;

            Console.Write("+");
            Console.Write(new string('-', windowWidth - 2));
            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines < windowHeight - 3; lines++)
            {
                Console.Write("|");
                Console.Write(new string(' ', windowWidth - 2));
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            Console.Write(new string('-', windowWidth - 2));
            Console.Write("+");
            Console.Write("\n");
        }

        static void WriteOptions()
        {
            int windowWidth = Console.WindowWidth;

            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(1, 3);
            Console.WriteLine(new string('=', windowWidth - 2));
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 12);
            Console.WriteLine("X ou x - Sair");
            Console.SetCursorPosition(3, 13);
            Console.Write("Opção: ");
        }

        static void HandleMenuOption(string option)
        {
            switch (option)
            {
                case "1": Editor.Show(); break;
                case "2": Viewer.Show(); break;
                case "X": 
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }

        static void WriteInput()
        {
            Console.SetCursorPosition(11, 13);
            var input = Console.ReadLine().ToUpper();
            HandleMenuOption(input);
        }
    }
}