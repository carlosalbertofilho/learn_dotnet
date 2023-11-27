using System;
using System.Text;

namespace EditorHtml
{
   class Editor
   {
         public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteInput();
        }
        static void DrawScreen()
        {
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine(new string('-', Console.WindowWidth - 1));
        }
        static void WriteInput()
        {
            var text = new StringBuilder();

            do
            {
                text.Append(Console.ReadLine());
                text.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine(new string('-', Console.WindowWidth - 1));
            Console.SetCursorPosition(1, Console.CursorTop + 1);
            Console.WriteLine("Qual o nome do arquivo?");
            Console.SetCursorPosition(1, Console.CursorTop + 1);
            var name = Console.ReadLine();

            
            using (var file = 
                new System.IO.StreamWriter($@"{Environment.CurrentDirectory}/{name}.html"))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {name}.html salvo!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();

            Menu.Show();
        }
   }
}