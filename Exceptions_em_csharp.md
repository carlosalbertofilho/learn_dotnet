# Tratamento de Exceções em C#

## Conceito

Exceções em C# são eventos que ocorrem durante a execução de um programa que interrompem o fluxo normal de instruções. Quando um erro ocorre dentro de um método, o sistema cria um novo objeto de exceção e o lança. O fluxo de controle do programa é interrompido e passado para o bloco de código mais próximo que é configurado para lidar com exceções.

## Uso

O tratamento de exceções em C# é feito usando quatro palavras-chave: `try`, `catch`, `finally` e `throw`.

- **try**: Um bloco `try` identifica um bloco de código para o qual as exceções serão ativadas.
- **catch**: Um bloco `catch` é usado para lidar com uma exceção. Pode haver vários blocos `catch` para um único bloco `try`.
- **finally**: Um bloco `finally` é usado para executar um determinado conjunto de instruções, seja uma exceção lançada ou não.
- **throw**: A palavra-chave `throw` é usada para lançar uma exceção explicitamente.

## Exemplo

Aqui está um exemplo simples de como o tratamento de exceções é feito em C#:

```csharp
try
{
    int[] arr = new int[5];
    arr[6] = 9;  // Index out of range exception
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}
finally
{
    Console.WriteLine("Execução do bloco finally");
}
```

Neste exemplo, estamos tentando atribuir um valor a um índice que não existe no array. Isso resultará em uma exceção `IndexOutOfRangeException`. O bloco `catch` captura a exceção e imprime a mensagem de erro. Independentemente de uma exceção ser lançada ou não, o bloco `finally` será executado.

## Exemplo de Tratamento

Considere o seguinte trecho de código:

```csharp
Console.WriteLine("Opção: ");
short option = short.Parse(TryReadShort());

static string TryReadShort()
{
    string? input = Console.ReadLine();
    if (input == null)
    {
        Console.WriteLine("Nenhuma entrada detectada, tente novamente: ");
        return TryReadShort();
    }
    else if (!short.TryParse(input, out short result))
    {
        Console.WriteLine("Entrada inválida, tente novamente: ");
        return TryReadShort();
    }
    else
    {
        return input;
    }
}

```

Para modificar o código acima para usar o tratamento de exceções em C#, podemos lançar exceções personalizadas quando a entrada for nula ou inválida. 
Aqui está um exemplo de como você pode fazer isso:

```csharp
Console.WriteLine("Opção: ");
short option = short.Parse(TryReadShort());

static string TryReadShort()
{
    try
    {
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentNullException("Nenhuma entrada detectada, tente novamente: ");
        }
        else if (!short.TryParse(input, out short result))
        {
            throw new FormatException("Entrada inválida, tente novamente: ");
        }
        else
        {
            return input;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        return TryReadShort();
    }
}
```

Neste código, se a entrada for nula, uma `ArgumentNullException` é lançada. Se a entrada não puder ser convertida para um número curto, uma `FormatException` é lançada. Ambas as exceções são capturadas no bloco `catch`, onde a mensagem de erro é impressa e a função `TryReadShort()` é chamada novamente. Isso continuará até que uma entrada válida seja fornecida.

# Exceções Personalizadas em C#

## Conceito

Exceções personalizadas são classes de exceção definidas pelo usuário que são derivadas, direta ou indiretamente, da classe `Exception`. Elas são usadas para representar erros específicos do programa que não são cobertos pelas exceções padrão do .NET.

## Uso

Para criar uma exceção personalizada, você precisa definir uma classe que herda de `Exception` ou de uma de suas subclasses. Você pode adicionar propriedades e métodos personalizados à sua classe de exceção, se necessário.

## Exemplo

Aqui está um exemplo de uma exceção personalizada em C#:

```csharp
public class InvalidUserAgeException : Exception
{
    public InvalidUserAgeException()
    {
    }

    public InvalidUserAgeException(string message)
        : base(message)
    {
    }

    public InvalidUserAgeException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
```

Neste exemplo, `InvalidUserAgeException` é uma exceção personalizada que é lançada quando a idade do usuário é inválida. Ela tem três construtores: um padrão, um que aceita uma mensagem de erro e um que aceita uma mensagem de erro e uma exceção interna.

Você pode lançar a exceção personalizada da seguinte maneira:

```csharp
int age = -1;

if (age < 0)
{
    throw new InvalidUserAgeException("A idade do usuário não pode ser negativa.");
}
```

Neste código, se a idade do usuário for menor que zero, uma `InvalidUserAgeException` será lançada com a mensagem "A idade do usuário não pode ser negativa.". A exceção pode então ser capturada e tratada em um bloco `catch`.

# Finally em C#

## Conceito

O bloco `finally` em C# é usado para executar um determinado conjunto de instruções, independentemente de uma exceção ser lançada ou não. É sempre executado após a execução dos blocos `try` e `catch`.

## Uso

O bloco `finally` é opcional e pode ser usado após os blocos `try` e `catch`. É útil para escrever código de limpeza, como fechar conexões de banco de dados ou arquivos, que deve ser executado independentemente de uma exceção ocorrer ou não.

## Exemplo

Aqui está um exemplo simples de como o bloco `finally` é usado em C#:

```csharp
try
{
    // Código que pode lançar uma exceção
}
catch (Exception e)
{
    // Lidar com a exceção
}
finally
{
    // Código que é sempre executado
}
```

Neste exemplo, o bloco `try` contém código que pode lançar uma exceção. Se uma exceção for lançada, o controle será passado para o bloco `catch`, que manipula a exceção. Independentemente de uma exceção ser lançada ou não, o bloco `finally` será sempre executado.

Aqui está um exemplo mais concreto:

```csharp
StreamReader reader = null;

try
{
    reader = new StreamReader("file.txt");
    // Leitura do arquivo
}
catch (FileNotFoundException e)
{
    // Lidar com a exceção
}
finally
{
    if (reader != null)
    {
        reader.Close();
    }
}
```

Neste exemplo, estamos tentando ler um arquivo. Se o arquivo não existir, uma `FileNotFoundException` será lançada. Independentemente de uma exceção ser lançada ou não, queremos garantir que o `StreamReader` seja fechado. Portanto, colocamos o código para fechar o `StreamReader` no bloco `finally`.