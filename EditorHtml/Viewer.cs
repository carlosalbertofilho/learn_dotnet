using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    class Viewer
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            ChooseFile();
            WriteInput();
        }
        static void DrawScreen(string text)
        {
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine(new string('-', Console.WindowWidth - 1));
            ReplaceStrong(text);
            Console.WriteLine(new string('-', Console.WindowWidth - 1));
        }
        static void OpenFile(string path)
        {
            var file = new System.IO.StreamReader(path);
            string text = file.ReadToEnd();
            file.Close();

            DrawScreen(text);
        }
        static void ChooseFile()
        {
            Console.WriteLine("Digite o nome do arquivo que deseja visualizar");
            Console.Write("Nome: ");
            var nameFile = Console.ReadLine();
            var path = $@"{Environment.CurrentDirectory}/{nameFile}.html";

            OpenFile(path);
        }
        static void WriteInput()
        {
            Console.ReadKey();
            Menu.Show();
        }

        static void ReplaceStrong(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            foreach (var word in words)
            {
                if (strong.IsMatch(word))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        word.Substring(
                            word.IndexOf('>') + 1,
                            (word.LastIndexOf('<') - 1) - word.IndexOf('>')) + " "
                    );
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.Write(word + " ");
                }
            }
        }
    }
}