using System.Globalization;

namespace TestProject
{
    class MyDecision
    {
        public static void Run()
        {
            Console.Clear();

            int saleAmount = 1001;
            Console.WriteLine($"O desconto é de {(saleAmount > 1000 ? 100 : 50)} reais");

            Console.WriteLine("--------------------");
            Console.WriteLine($"The result of the coin toss was {FlipCoin()}");

            Console.WriteLine("--------------------");
            string permission = "Admin|Manager";
            int level = 55;
            Console.WriteLine(AccessLevel(permission, level));

            Console.WriteLine("--------------------");
            MyLoop(100);

            Console.WriteLine("--------------------");
            FixTheCode();
        }

        // Neste desafio, você implementará um operador condicional
        //  para simular um "lançamento de moeda". A lógica de decisão
        // resultante exibirá heads ou tails.
        public static string FlipCoin() => new Random().Next(0, 2) == 0 ? "heads" : "tails";

        /*
        * Neste desafio, você implementará a lógica de decisão com base
        * em uma série de regras de negócios. As regras de negócios
        * especificam o acesso que será concedido aos usuários com base
        * nas respectivas permissões baseadas em função e no nível de carreira
        */
        public static string AccessLevel(string permission, int level)
        {
            if (permission == "Manager" && level >= 55)
                return "Welcome, Super Admin user.";
            else if (permission == "Manager")
                return "Welcome, Admin user.";
            else if (permission == "Admin" && level >= 20)
                return "Contact an Admin for access.";
            else
                return "Welcome, Admin user.";
        }

        /*
        * Neste desafio, você usará o que aprendeu sobre blocos de código
        * e escopo de variável para corrigir o exemplo de código mal escrito
        * fornecido. Há muitas melhorias que você pode fazer. Boa sorte!
        */
        public static void FixTheCode()
        {
            var numbers = new int[] { 4, 8, 15, 16, 23, 42 };
            var total = 0;
            var found = false;

            foreach (var number in numbers)
            {
                total += number;
                if (number == 42)
                    found = true;
            }

            if (found)
                Console.WriteLine("Set contains 42");

            Console.WriteLine($"Total: {total}");
        }

        public static void MyForLoop()
        {
            foreach (var number in Enumerable.Range(1, 100))
            {
                if (number % 3 == 0 && number % 5 == 0)
                    Console.WriteLine($"{number} - FizzBuzz");
                else if (number % 3 == 0)
                    Console.WriteLine($"{number} - Fizz");
                else if (number % 5 == 0)
                    Console.WriteLine($"{number} - Buzz");
                else
                    Console.WriteLine(number);
            }
        }

        public static void MyLoop(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                Console.WriteLine($"{number} - FizzBuzz");
            else if (number % 3 == 0)
                Console.WriteLine($"{number} - Fizz");
            else if (number % 5 == 0)
                Console.WriteLine($"{number} - Buzz");
            else
                Console.WriteLine(number);

            if (number > 0)
                MyLoop(number - 1);
        }

        public static void MyLoop3()
        {
            Enumerable
                .Range(1, 100)
                .ToList()
                .ForEach(number =>
                {
                    if (number % 3 == 0 && number % 5 == 0)
                        Console.WriteLine($"{number} - FizzBuzz");
                    else if (number % 3 == 0)
                        Console.WriteLine($"{number} - Fizz");
                    else if (number % 5 == 0)
                        Console.WriteLine($"{number} - Buzz");
                    else
                        Console.WriteLine(number);
                });
        }
    }
}
