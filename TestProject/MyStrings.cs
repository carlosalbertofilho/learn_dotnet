using System;

namespace TestProject
{
    class MyString
    {
        public static void MyGuids()
        {
            var id = Guid.NewGuid();
            Console.WriteLine(id);
        }

        public static void MyInterpolation()
        {
            var name = "Carlos";
            var lastName = "Filho";
            var age = 34;
            var height = 1.85;

            Console.WriteLine($"Id: {Guid.NewGuid()}");
            Console.WriteLine($"Nome: {name} {lastName}, Idade: {age}, Altura: {height}");
        }

        public static void MyCompare()
        {
            var texto = "Testando";
            Console.WriteLine("Usando o método CompareTo: ");
            Console.WriteLine(texto.CompareTo("Testando")); // Retorna 0 se for igual
            Console.WriteLine(texto.CompareTo("testando")); // Retorna 1 se for diferente

            Console.WriteLine("Usando o método Contains: ");
            Console.WriteLine(texto.Contains("Test")); // Retorna true se contém
            Console.WriteLine(texto.Contains("test")); // Retorna false se não contém

            texto = "Este texto é um teste";

            Console.WriteLine("Usando o método StartsWith: ");
            Console.WriteLine(texto.StartsWith("Este")); // Retorna true se começa com
            Console.WriteLine(texto.StartsWith("este")); // Retorna false se não começa com

            Console.WriteLine("Usando o método EndsWith: ");
            Console.WriteLine(texto.EndsWith("teste")); // Retorna true se termina com
            Console.WriteLine(texto.EndsWith("Teste")); // Retorna false se não termina com

            Console.WriteLine("Usando o método Equals: ");
            Console.WriteLine(texto.Equals("Testando")); // Retorna true se for igual
            
            Console.WriteLine("Usando o método IndexOf: ");
            Console.WriteLine(texto.IndexOf("é")); // Retorna a posição da primeira ocorrência

            Console.WriteLine("Usando o método ToLower: ");
            Console.WriteLine(texto.ToLower()); // Retorna o texto em minúsculo

            Console.WriteLine("Usando o método ToUpper: ");
            Console.WriteLine(texto.ToUpper()); // Retorna o texto em maiúsculo

            Console.WriteLine("Usando o método Trim: ");
            Console.WriteLine(texto.Trim()); // Retorna o texto sem espaços no início e no fim

            Console.WriteLine("Usando o método Insert: ");
            Console.WriteLine(texto.Insert(5, "teste")); // Retorna o texto com a string inserida na posição indicada

            Console.WriteLine("Usando o método Remove: ");
            Console.WriteLine(texto.Remove(5, 5)); // Retorna o texto sem a string removida na posição indicada

            Console.WriteLine("Usando o método Replace: ");
            Console.WriteLine(texto.Replace("é", "e")); // Retorna o texto com a string substituída

            Console.WriteLine("Usando o método Length: ");
            Console.WriteLine(texto.Length); // Retorna o tamanho do texto

            Console.WriteLine("Usando o método Split: ");
            var textoSplit = texto.Split(" ");
            foreach (var item in textoSplit)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Usando o método Substring: ");
            Console.WriteLine(texto.Substring(5, 5)); // Retorna o texto a partir da posição indicada
        }

        public void MyStringBuilder()
        {
            var texto = new System.Text.StringBuilder();
            texto.Append("Este texto é um teste");
            texto.AppendLine(" de StringBuilder");
            texto.AppendLine("para concatenar textos");
            texto.AppendLine("de forma eficiente");
            Console.WriteLine(texto.ToString());
        }
    }
}