using System;
using System.Globalization;

namespace TestProject
{
    class MyData
    {
        public static void Show()
        {
            Console.Clear();

            var pt = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");

            Console.WriteLine("Usando o método CultureInfo: ");
            Console.WriteLine("Usando cultura pt-BR: "+DateTime.Now.ToString("D", pt)); // Retorna a data no formato longo   
            Console.WriteLine("Usando cultura en-US, padrão: "+DateTime.Now.ToString("D", en)); // Retorna a data no formato longo   

            TimeSpan timeSpan = new TimeSpan(2, 14, 18);

            // Exiba a duração total em horas
            Console.WriteLine("Duração total em horas: " + timeSpan.TotalHours);

            // Exiba a duração total em minutos
            Console.WriteLine("Duração total em minutos: " + timeSpan.TotalMinutes);

            // Exiba a duração total em segundos
            Console.WriteLine("Duração total em segundos: " + timeSpan.TotalSeconds);
        }
    }
}