using System;
using System.Runtime.InteropServices;

namespace TestProject
{
    class MyWhile
    {
        public static void Run()
        {
            Console.Clear();

            ReadInt();

            Console.WriteLine("---------------------------------------");

            ReadString();

            Console.WriteLine("---------------------------------------");

            SplitPhrase();
        }

        static void SplitPhrase()
        {
            string[] myStrings =
            [
                "I like pizza. I like roast chicken. I like salad",
                "I like all three of the menu choices"
            ];

            foreach (var item in myStrings)
            {
                var myString = item;
                do
                {
                    var index = myString.IndexOf('.');
                    if (index == -1)
                    {
                        Console.WriteLine(myString);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(
                            myString[..index].TrimStart('.').Trim());
                        myString = myString[(index + 1)..];
                    }
                } while (true);
            }
        }

        /**
        * valida a entrada de cadeia de caracteres
         - A solução deve usar uma instrução Console.ReadLine()
          para obter uma entrada do usuário.
         - A solução deve garantir que o valor inserido corresponda
           a uma das três opções de função.
         - Sua solução deve usar o método Trim() no valor de entrada
           para ignorar caracteres de espaço de entrelinhamento e à direita.
         - A solução deve usar o método ToLower() no valor de entrada para
           ignorar maiúsculas e minúsculas.
        **/
        public static void ReadString()
        {
            string? input;
            bool valid = false;

            Console.WriteLine("Enter your role name (Administrator, Manager, or User): ");
            do
            {
                input = Console.ReadLine();
                input = input?.Trim().ToLower();

                switch (input)
                {
                    case "administrator":
                    case "manager":
                    case "user":
                        valid = true;
                        Console.WriteLine($"Role {input} accepted!");
                        break;
                    default:
                        Console.WriteLine("Invalid entry, try again: ");
                        break;
                }
            } while (!valid);
        }

        /**  Escrever o código que valida a entrada de inteiro
        Veja as seguintes condições que seu primeiro projeto de codificação
        deve implementar:
         - A solução deve incluir uma iteração do-while ou while.
         - Antes do bloco de iteração: a solução deve usar uma
           instrução Console.WriteLine() para solicitar ao usuário
           um valor inteiro entre 5 e 10.
         - Dentro do bloco de iteração:

        A solução deve usar uma instrução Console.ReadLine() para obter
        uma entrada do usuário. A solução deve garantir que a entrada
        seja uma representação válida de um inteiro.
        Se o valor inteiro não estiver entre 5 e 10, o código deverá usar
        uma instrução Console.WriteLine() para solicitar ao usuário um valor
        inteiro entre 5 e 10.
        A solução deve garantir que o valor inteiro esteja entre 5 e 10 antes
        de sair da iteração. Abaixo (depois) do bloco de código de iteração:
        a solução deve usar uma instrução Console.WriteLine() para informar
        ao usuário que o valor de entrada foi aceito.
        */
        public static void ReadInt()
        {
            string? input;
            bool valid = false;

            Console.WriteLine("Digite um número entre 5 e 10: ");
            do
            {
                input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Nenhuma entrada detectada, tente novamente: ");
                    continue;
                }
                else if (!int.TryParse(input, out int result))
                {
                    Console.WriteLine("Entrada inválida, tente novamente: ");
                    continue;
                }
                else if (result < 5 || result > 10)
                {
                    Console.WriteLine("Entrada fora do intervalo, tente novamente: ");
                    continue;
                }
                else
                {
                    valid = true;
                    Console.WriteLine($"Entrada {result} aceita!");
                }
            } while (!valid);
        }
    }
}
