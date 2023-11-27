# Métodos de `String` em C# com exemplos. 

1. **CompareTo**: Este método compara duas strings e retorna um inteiro que indica a relação de ordem entre as duas strings.
    ```csharp
    string str1 = "apple";
    string str2 = "banana";
    int result = str1.CompareTo(str2);  // result é -1 porque "apple" é menor que "banana" em ordem alfabética
    ```

2. **Contains**: Este método verifica se uma string contém uma sub-string específica.
    ```csharp
    string str = "Hello, world!";
    bool containsWorld = str.Contains("world");  // containsWorld é true
    ```

3. **StartsWith**: Este método verifica se uma string começa com uma sub-string específica.
    ```csharp
    string str = "Hello, world!";
    bool startsWithHello = str.StartsWith("Hello");  // startsWithHello é true
    ```

4. **EndsWith**: Este método verifica se uma string termina com uma sub-string específica.
    ```csharp
    string str = "Hello, world!";
    bool endsWithWorld = str.EndsWith("world!");  // endsWithWorld é true
    ```

5. **Equals**: Este método verifica se duas strings são iguais.
    ```csharp
    string str1 = "apple";
    string str2 = "apple";
    bool areEqual = str1.Equals(str2);  // areEqual é true
    ```

6. **IndexOf**: Este método retorna o índice da primeira ocorrência de uma sub-string em uma string.
    ```csharp
    string str = "Hello, world!";
    int indexOfWorld = str.IndexOf("world");  // indexOfWorld é 7
    ```

7. **ToLower**: Este método converte todos os caracteres em uma string para minúsculas.
    ```csharp
    string str = "Hello, World!";
    string lowerStr = str.ToLower();  // lowerStr é "hello, world!"
    ```

8. **ToUpper**: Este método converte todos os caracteres em uma string para maiúsculas.
    ```csharp
    string str = "Hello, World!";
    string upperStr = str.ToUpper();  // upperStr é "HELLO, WORLD!"
    ```

9. **Trim**: Este método remove todos os espaços em branco no início e no final de uma string.
    ```csharp
    string str = "   Hello, world!   ";
    string trimmedStr = str.Trim();  // trimmedStr é "Hello, world!"
    ```

10. **Insert**: Este método insere uma string em um índice específico em outra string.
    ```csharp
    string str = "Hello, world!";
    string newStr = str.Insert(7, "beautiful ");  // newStr é "Hello, beautiful world!"
    ```

11. **Remove**: Este método remove um número específico de caracteres de uma string a partir de um índice específico.
    ```csharp
    string str = "Hello, beautiful world!";
    string newStr = str.Remove(7, 10);  // newStr é "Hello, world!"
    ```

12. **Length**: Esta propriedade retorna o número de caracteres em uma string.
    ```csharp
    string str = "Hello, world!";
    int length = str.Length;  // length é 13
    ```

13. **Replace**: Este método substitui todas as ocorrências de uma sub-string por outra sub-string em uma string.
    ```csharp
    string str = "Hello, world!";
    string newStr = str.Replace("world", "universe");  // newStr é "Hello, universe!"
    ```

14. **Substring**: Este método retorna uma sub-string que começa em um índice específico e tem um comprimento específico.
    ```csharp
    string str = "Hello, world!";
    string subStr = str.Substring(7, 5);  // subStr é "world"
    ```

15. **Split**: Este método divide uma string em um array de strings com base em um delimitador específico.
    ```csharp
    string str = "Hello, world!";
    string[] words = str.Split(' ');  // words é ["Hello,", "world!"]
    ```


# StringBuilder
Claro, vou explicar o conceito do `StringBuilder` em C# com um exemplo.

O `StringBuilder` é uma classe em C# que é usada para manipular strings de maneira eficiente. Diferentemente da classe `String`, que cria um novo objeto de string cada vez que você concatena, modifica ou manipula strings, a classe `StringBuilder` permite que você faça essas operações sem criar novos objetos de string. Isso pode ser muito útil quando você está trabalhando com grandes quantidades de texto ou realizando muitas operações de string, pois pode melhorar significativamente o desempenho do seu programa.

Aqui está um exemplo de como você pode usar o `StringBuilder`:

```csharp
using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        // Adiciona strings ao StringBuilder
        sb.Append("Olá, ");
        sb.Append("mundo!");

        // Modifica a string no StringBuilder
        sb.Replace("mundo", "universo");

        // Insere uma string em um índice específico
        sb.Insert(5, "maravilhoso ");

        // Remove caracteres em um índice específico
        sb.Remove(5, 12);

        // Obtém a string do StringBuilder
        string str = sb.ToString();

        Console.WriteLine(str);  // Imprime "Olá, universo!"
    }
}
```

Neste exemplo, criamos um `StringBuilder`, adicionamos algumas strings a ele, modificamos a string no `StringBuilder`, inserimos uma nova string em um índice específico, removemos alguns caracteres e, finalmente, obtivemos a string resultante do `StringBuilder`. E tudo isso foi feito sem criar novos objetos de string!

Espero que isso ajude! Deixe-me saber se você tem mais perguntas. 😊