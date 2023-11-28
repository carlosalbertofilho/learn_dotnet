# Moedas em C#

Em C#, não existe um tipo de dados específico para representar moedas. No entanto, o tipo de dados `decimal` é comumente usado para representar valores monetários devido à sua alta precisão e capacidade de evitar erros de arredondamento que podem ocorrer com tipos de ponto flutuante como `double` ou `float`.

Aqui está um exemplo de como você pode usar o tipo `decimal` para representar valores monetários em C#:

```csharp
// Declare uma variável para representar um valor monetário
decimal valor = 19.99m;

// Exiba o valor
Console.WriteLine("O valor é: " + valor.ToString("C"));
```

Neste exemplo, um novo valor `decimal` é criado para representar um valor monetário de 19.99. O sufixo `m` é usado para indicar que o número é um valor `decimal`. O método `ToString("C")` é então usado para converter o valor `decimal` em uma string formatada como um valor monetário. O argumento `"C"` indica que o valor deve ser formatado como uma moeda.

Além disso, a classe `CultureInfo` do namespace `System.Globalization` pode ser usada para formatar valores monetários em diferentes moedas. Aqui está um exemplo:

```csharp
// Importe o namespace necessário
using System.Globalization;

// Crie um novo objeto CultureInfo para representar a cultura dos EUA
CultureInfo cultura = new CultureInfo("en-US");

// Declare uma variável para representar um valor monetário
decimal valor = 19.99m;

// Exiba o valor formatado como uma moeda dos EUA
Console.WriteLine("O valor em dólares é: " + valor.ToString("C", cultura));
```

Neste exemplo, um novo objeto `CultureInfo` é criado para representar a cultura dos EUA. O valor `decimal` é então formatado como uma moeda dos EUA usando o método `ToString("C", cultura)`. O argumento `"C"` indica que o valor deve ser formatado como uma moeda, e o argumento `cultura` especifica a cultura a ser usada para a formatação. 

# Arredondando valores.

## Math.Round
O método `Math.Round` na linguagem de programação C# é usado para arredondar um valor decimal ou de ponto flutuante para o número inteiro mais próximo. Aqui está um exemplo de como você pode usar `Math.Round`:

```csharp
// Declare um número decimal
double numero = 9.85;

// Arredonde o número para o inteiro mais próximo
double numeroArredondado = Math.Round(numero);

// Exiba o número arredondado
Console.WriteLine("O número arredondado é: " + numeroArredondado);
```

Neste exemplo, um novo número `double` é criado para representar o valor 9.85. O método `Math.Round` é então usado para arredondar esse número para o inteiro mais próximo. O resultado é armazenado na variável `numeroArredondado` e, em seguida, exibido no console.

É importante notar que `Math.Round` usa o arredondamento para o número par mais próximo se o número estiver exatamente no meio do caminho entre dois inteiros. Por exemplo, `Math.Round(3.5)` resultará em 4, enquanto `Math.Round(2.5)` resultará em 2.

## Math.Ceiling
O método `Math.Ceiling` na linguagem de programação C# é usado para arredondar um valor decimal ou de ponto flutuante para o número inteiro mais próximo e maior. Aqui está um exemplo de como você pode usar `Math.Ceiling`:

```csharp
// Declare um número decimal
double numero = 9.25;

// Arredonde o número para o inteiro mais próximo e maior
double numeroArredondado = Math.Ceiling(numero);

// Exiba o número arredondado
Console.WriteLine("O número arredondado é: " + numeroArredondado);
```

Neste exemplo, um novo número `double` é criado para representar o valor 9.25. O método `Math.Ceiling` é então usado para arredondar esse número para o inteiro mais próximo e maior. O resultado é armazenado na variável `numeroArredondado` e, em seguida, exibido no console.

É importante notar que `Math.Ceiling` sempre arredonda para cima, independentemente da fração do número. Por exemplo, `Math.Ceiling(9.1)` resultará em 10, e `Math.Ceiling(9.9)` também resultará em 10.

## Math.Floor
O método `Math.Floor` na linguagem de programação C# é usado para arredondar um valor decimal ou de ponto flutuante para o número inteiro mais próximo e menor. Aqui está um exemplo de como você pode usar `Math.Floor`:

```csharp
// Declare um número decimal
double numero = 9.85;

// Arredonde o número para o inteiro mais próximo e menor
double numeroArredondado = Math.Floor(numero);

// Exiba o número arredondado
Console.WriteLine("O número arredondado é: " + numeroArredondado);
```

Neste exemplo, um novo número `double` é criado para representar o valor 9.85. O método `Math.Floor` é então usado para arredondar esse número para o inteiro mais próximo e menor. O resultado é armazenado na variável `numeroArredondado` e, em seguida, exibido no console.

É importante notar que `Math.Floor` sempre arredonda para baixo, independentemente da fração do número. Por exemplo, `Math.Floor(9.1)` resultará em 9, e `Math.Floor(9.9)` também resultará em 9.

