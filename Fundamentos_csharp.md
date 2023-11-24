# Fundamentos da Linguagem C#

## Escopo de um programa
Aqui estão as definições dos conceitos solicitados na linguagem C#:

- **Importações**: Em C#, as importações são realizadas através da diretiva `using`. Ela permite o uso de tipos em um namespace para que você não tenha que qualificar a utilização de um tipo em um namespace. Por exemplo, `using System;` permite que você use o tipo `Console` em vez de `System.Console`.

- **Namespace**: Um namespace é usado para organizar seu código e é uma coleção de classes, interfaces, structs, enums e delegates. Por exemplo, o namespace `System` contém uma série de classes, como `Console`, que são usadas frequentemente na programação C#.

- **Classe**: Uma classe é uma construção que permite criar seus próprios tipos personalizados combinando variáveis de outros tipos, métodos e eventos. Uma classe é como um blueprint. Define os dados e o comportamento dos tipos.

- **Método Principal**: O método principal é o ponto de entrada para um aplicativo C#. Quando o aplicativo é iniciado, o método principal é o primeiro método que é invocado. Ele deve ser `static` e `void`. 
Por exemplo:
```csharp
using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Testando";
            Console.WriteLine(texto);
        }
    }
}
```

## Namespace

O conceito de **namespace** em C# é semelhante a uma forma de organizar suas gavetas. Imagine que você tem uma gaveta cheia de diferentes tipos de objetos: lápis, canetas, borrachas, apontadores, etc. Se você simplesmente jogar tudo na gaveta sem qualquer organização, pode ser difícil encontrar o que você precisa quando precisar.

Agora, imagine que você decide organizar sua gaveta usando divisórias ou caixas menores dentro da gaveta maior. Você coloca todas as suas canetas em uma caixa, todos os seus lápis em outra, e assim por diante. Agora, quando você precisa de uma caneta, você sabe exatamente onde procurar.

Em C#, um **namespace** é como essas caixas menores na sua gaveta. Ele permite que você organize seu código de maneira que seja mais fácil de encontrar e usar. Cada namespace pode conter classes, structs, enums, delegates e outros namespaces.

Aqui está um exemplo de como um namespace pode ser usado em C#:

```csharp
// Definindo o namespace
namespace MeuNamespace
{
    class MinhaClasse
    {
        public void MeuMetodo()
        {
            System.Console.WriteLine("Olá, mundo!");
        }
    }
}

// Usando o namespace
class Programa
{
    static void Main()
    {
        MeuNamespace.MinhaClasse obj = new MeuNamespace.MinhaClasse();
        obj.MeuMetodo();
    }
}
```

Neste exemplo, `MeuNamespace` é o namespace que criamos. Dentro desse namespace, temos uma classe chamada `MinhaClasse` com um método chamado `MeuMetodo`. Quando queremos usar `MinhaClasse`, temos que especificar que ela está no namespace `MeuNamespace`.

## Using

O comando `using` em C# é como um atalho que você cria no seu computador para acessar rapidamente um arquivo ou programa. Sem o atalho, você teria que navegar por várias pastas até encontrar o que está procurando. Com o atalho, você pode acessar o que precisa com apenas um clique.

No C#, o comando `using` cria um tipo de "atalho" para namespaces, permitindo que você acesse as classes, structs, enums e delegates dentro deles sem ter que digitar o nome completo do namespace toda vez.

Por exemplo, sem o comando `using`, você teria que digitar `System.Console.WriteLine("Olá, mundo!");` para escrever uma mensagem no console. Isso pode se tornar cansativo se você tiver que fazer isso muitas vezes no seu código.

Mas se você adicionar `using System;` no início do seu código, você pode simplesmente escrever `Console.WriteLine("Olá, mundo!");`, o que é muito mais rápido e fácil de digitar.

Aqui está um exemplo de como o comando `using` pode ser usado em C#:

```csharp
// Usando o comando 'using'
using System;

class Programa
{
    static void Main()
    {
        // Agora podemos usar 'Console' diretamente, sem precisar digitar 'System.Console'
        Console.WriteLine("Olá, mundo!");
    }
}
```

## Variáveis

### Variável por Tipagem Explícita

Em C#, uma **variável** é como uma caixa em um armazém. Cada caixa tem um nome único (o nome da variável) e pode conter algo dentro (o valor da variável). Além disso, cada caixa deve ser do tamanho certo para o que você quer colocar dentro dela (o tipo da variável).

Por exemplo, se você tem um número inteiro, você pode querer colocá-lo em uma caixa chamada `idade` que é do tamanho certo para números inteiros. Em C#, você faria isso assim:

```csharp
int idade = 30;
```

Neste exemplo, `int` é o tipo da variável (significando que é uma caixa do tamanho certo para um número inteiro), `idade` é o nome da variável (o nome único da caixa), e `30` é o valor da variável (o número inteiro que estamos colocando na caixa).

Você também pode mudar o que está dentro da caixa em qualquer momento, assim:

```csharp
idade = 31;
```

Agora a caixa chamada `idade` contém o número `31` em vez de `30`.

### Variável por Tipagem Implícita

Em C#, a palavra-chave `var` é usada para declarar uma variável cujo tipo é inferido pelo compilador com base no valor que você atribui a ela. Isso é chamado de **tipagem implícita**.

Imagine que você está empacotando um presente, mas não tem uma caixa do tamanho exato para ele. Então, você usa uma caixa ajustável que pode mudar de tamanho para se adequar ao presente. A palavra-chave `var` é como essa caixa ajustável.

Por exemplo, em vez de declarar explicitamente o tipo de uma variável como `int`, `string`, etc., você pode usar `var` e o compilador inferirá o tipo com base no valor atribuído:

```csharp
var idade = 30; // O compilador inferirá que 'idade' é do tipo 'int'
var nome = "Maria"; // O compilador inferirá que 'nome' é do tipo 'string'
```

Neste exemplo, o compilador determina que `idade` é um `int` e `nome` é uma `string` com base nos valores que atribuímos a eles.

No entanto, uma vez que um valor é atribuído a uma variável declarada com `var`, o tipo dessa variável não pode ser alterado. Por exemplo, depois de declarar `var idade = 30;`, você não pode então atribuir `idade = "trinta";`, pois "trinta" é uma string, não um inteiro.



## Constantes

Em C#, uma **constante** é um tipo de variável cujo valor não pode ser alterado depois de ser definido inicialmente. É como se você tivesse uma caixa trancada onde você pode colocar algo dentro, mas uma vez que a caixa está trancada, você não pode mais mudar o que está dentro dela.

Definições
- Utilize nomes coesos
- Não utilize caracteres especiais ou espaços
- Não comece com número
- é Comum vermos constantes todas em maiúsculas, separadas por "_"
- A ideia é bate o olho no código e saber que aquilo é uma constante

Você declara uma constante em C# usando a palavra-chave `const` seguida pelo tipo da constante, o nome da constante e o valor da constante. Por exemplo:

```csharp
const int MINHA_CONSTANTE = 10;
```

Neste exemplo, `MINHA_CONSTANTE` é uma constante do tipo `int` que tem o valor `10`. Se você tentar mudar o valor de `MINHA_CONSTANTE` depois disso, você receberá um erro do compilador.

Por exemplo, o seguinte código resultará em um erro:

```csharp
const int MINHA_CONSTANTE = 10;
MINHA_CONSTANTE = 20; // Isso causará um erro
```

As constantes são úteis quando você tem um valor que não deve ser alterado, como o valor de pi em cálculos matemáticos.

## Palavras reservadas

As palavras reservadas em C# são como os comandos especiais que você pode dar a um cão treinado. Assim como um cão treinado sabe que “sentar” significa que ele deve sentar-se, o compilador C# sabe que cada palavra reservada tem um significado especial e realiza uma ação específica quando a vê.

Aqui estão as palavras reservadas na linguagem C#:

```
|-------------------------------|     |----------------------------|
|       Palavras Reservadas     |     | Palavras-Chave Contextuais |
|-------------------------------|     |----------------------------|
| abstract      |  implicit     |     | add                        |
| as            |  in           |     | and                        |
| base          |  int          |     | alias                      |
| bool          |  interface    |     | ascending                  |
| break         |  internal     |     | args                       |
| byte          |  is           |     | async                      |
| case          |  lock         |     | await                      |
| catch         |  long         |     | by                         |
| char          |  namespace    |     | descending                 |
| checked       |  new          |     | dynamic                    |
| class         |  null         |     | equals                     |
| const         |  object       |     | from                       |
| continue      |  operator     |     | get                        |
| decimal       |  out          |     | global                     |
| default       |  override     |     | group                      |
| params        |  private      |     | init                       |
| delegate      |  protected    |     | into                       |
| do            |  public       |     | join                       |
| double        |  readonly     |     | let                        |
| else          |  ref          |     | managed                    |
| enum          |  return       |     | nameof                     |
| event         |  sbyte        |     | nint                       |
| explicit      |  sealed       |     | not                        |
| extern        |  short        |     | notnull                    |
| false         |  sizeof       |     | nuint                      |
| finally       |  stackalloc   |     | on                         |
| fixed         |  static       |     | or                         |
| float         |  string       |     | orderby                    |
| for           |  struct       |     | partial                    |
| foreach       |  switch       |     | record                     |
| goto          |  this         |     | remove                     |
| if            |  throw        |     | select                     |
| true          |  while        |     | set                        |
| try           |  volatile     |     | unmanaged                  |
| typeof        |  void         |     | value                      |
| uint          |  virtual      |     | var                        |
| ulong         |  using        |     | when                       |
| unchecked     |  ushort       |     | where                      |
| unsafe        |               |     | with                       |       
|               |               |     | yield                      |
|-------------------------------|     |----------------------------|
```

Essas palavras-chave são identificadores reservados predefinidos com significados especiais para o compilador¹. Elas não podem ser usadas como identificadores em seu programa, a não ser que incluam `@` como prefixo¹. Por exemplo, `@if` é um identificador válido, mas `if` não é porque `if` é uma palavra-chave¹.

Origem:
(2) Palavras-chave C# | Microsoft Learn. https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/.
(3) C#. Keywords in C#. Reserved words. Context words | BestProg. https://www.bestprog.net/en/2019/06/07/c-keywords-in-c-reserved-words-context-words/.
(4) How do I use a C# reserved keyword as a property name without the .... https://stackoverflow.com/questions/10912631/how-do-i-use-a-c-sharp-reserved-keyword-as-a-property-name-without-the-prefix.

## Comentários

Os **comentários** em C# são como notas adesivas que você coloca no seu código. Eles são mensagens que você deixa para si mesmo e para outros desenvolvedores para explicar o que o código está fazendo. O compilador C# ignora os comentários, então eles não afetam o funcionamento do seu programa.

Existem dois tipos de comentários em C#:

1. **Comentários de linha única**: Começam com `//`. Tudo na mesma linha após `//` é considerado parte do comentário e é ignorado pelo compilador. Por exemplo:

```csharp
// Este é um comentário de linha única
int minhaVariavel = 10;
```

2. **Comentários de várias linhas**: Começam com `/*` e terminam com `*/`. Tudo entre `/*` e `*/` é considerado parte do comentário e é ignorado pelo compilador. Por exemplo:

```csharp
/* Este é um
comentário de
várias linhas */
int minhaVariavel = 10;
```

Os comentários são uma parte importante da escrita de um bom código. Eles podem ajudar a tornar o seu código mais compreensível para você e para outros desenvolvedores que possam trabalhar no seu código no futuro.

## Tipos em C#

### Primitivos e Complexos

Em C#, os tipos de dados podem ser categorizados em **tipos primitivos** e **tipos complexos**.

**Tipos Primitivos**: São os tipos de dados básicos fornecidos pela linguagem C#. Eles incluem:

- `int`: usado para armazenar números inteiros. Por exemplo, `int idade = 25;`
- `double`: usado para armazenar números de ponto flutuante (números com casas decimais). Por exemplo, `double salario = 3000.50;`
- `char`: usado para armazenar um único caractere. Por exemplo, `char genero = 'M';`
- `bool`: usado para armazenar valores verdadeiro ou falso. Por exemplo, `bool estaChovendo = false;`

**Tipos Complexos**: São tipos de dados que são construídos a partir dos tipos primitivos. Eles incluem:

- **Arrays**: Um array é uma coleção de variáveis do mesmo tipo. Por exemplo, `int[] numeros = new int[5];` cria um array de inteiros com 5 elementos.
- **Classes**: Uma classe é uma definição para um tipo de dados que pode incluir variáveis e métodos. Por exemplo:
```csharp
class Carro
{
    string marca;
    int ano;

    void LigarMotor()
    {
        // Código para ligar o motor
    }
}
```
Neste exemplo, `Carro` é uma classe que tem duas variáveis (`marca` e `ano`) e um método (`LigarMotor`).

- **Structs**: Semelhante a uma classe, mas geralmente usado para pequenas estruturas de dados. Por exemplo:
```csharp
struct Ponto
{
    public int x;
    public int y;
}
```
Neste exemplo, `Ponto` é uma struct que tem duas variáveis (`x` e `y`).

### Namespace System

Em C#, `System` é um **namespace** que contém classes fundamentais e classes base que definem tipos de dados de valor e de referência comumente usados, eventos e manipuladores de eventos, interfaces, atributos e exceções de processamento. 

Por exemplo, a classe `System.Console` fornece uma interface para o console padrão de entrada, saída e erro. Aqui está um exemplo de como você pode usar `System.Console` para imprimir uma mensagem na tela:

```csharp
System.Console.WriteLine("Olá, mundo!");
```

No entanto, é comum usar a diretiva `using` no início do seu código para evitar ter que digitar `System.` toda vez que você quiser usar uma classe dentro do namespace `System`. Por exemplo:

```csharp
using System;

class Programa
{
    static void Main()
    {
        Console.WriteLine("Olá, mundo!");
    }
}
```

Neste exemplo, adicionamos `using System;` no início do nosso código, então podemos usar `Console.WriteLine` em vez de `System.Console.WriteLine`.

### Byte

O tipo `byte` em C# é um tipo de dados primitivo que armazena valores de 0 a 255. É um tipo de valor que é representado por um byte de 8 bits. 

Imagine que você tem uma fileira de 8 caixas, e cada caixa pode conter apenas um 0 ou um 1. Essa é a representação de um byte. Como cada caixa pode conter dois valores possíveis (0 ou 1), e você tem 8 caixas, isso significa que você pode representar 2^8 ou 256 valores diferentes com um byte. Como começamos a contar do 0, os valores possíveis vão de 0 a 255.

Aqui está um exemplo de como você pode usar o tipo `byte` em C#:

```csharp
byte meuByte = 200;
Console.WriteLine(meuByte); // Imprime "200"
```

Neste exemplo, `meuByte` é uma variável do tipo `byte` que armazena o valor `200`. Quando imprimimos `meuByte`, vemos o valor `200` na tela.

### Sbyte
O tipo `sbyte` em C# é um tipo de dados primitivo que armazena valores de -128 a 127. É um tipo de valor que é representado por um byte de 8 bits, assim como o tipo `byte`, mas a diferença é que o `sbyte` é um tipo **signed**, o que significa que ele pode representar tanto números positivos quanto negativos.

Imagine que você tem uma fileira de 8 caixas, e cada caixa pode conter apenas um 0 ou um 1, assim como no tipo `byte`. No entanto, no tipo `sbyte`, a primeira caixa é usada para indicar se o número é positivo ou negativo (0 para positivo, 1 para negativo), e as outras 7 caixas são usadas para representar o valor do número. Isso significa que você pode representar 2^7 ou 128 valores diferentes com um `sbyte`, metade dos quais são negativos (de -128 a -1) e metade dos quais são positivos (de 0 a 127).

Aqui está um exemplo de como você pode usar o tipo `sbyte` em C#:

```csharp
sbyte meuSByte = -100;
Console.WriteLine(meuSByte); // Imprime "-100"
```

Neste exemplo, `meuSByte` é uma variável do tipo `sbyte` que armazena o valor `-100`. Quando imprimimos `meuSByte`, vemos o valor `-100` na tela.

### Números Inteiros

Em C#, os tipos `short`, `ushort`, `int`, `uint`, `long` e `ulong` são todos tipos de dados numéricos inteiros, mas eles diferem em dois aspectos principais: o tamanho (ou seja, quantos bits de memória eles usam) e se eles são signed (podem representar tanto números positivos quanto negativos) ou unsigned (podem representar apenas números não negativos).

Aqui estão as definições desses tipos:

- **short**: É um tipo de dados integral signed de 16 bits que pode representar valores de -32.768 a 32.767. Por exemplo:
```csharp
short meuShort = 30000;
```

- **ushort**: É um tipo de dados integral unsigned de 16 bits que pode representar valores de 0 a 65.535. Por exemplo:
```csharp
ushort meuUshort = 60000;
```

- **int**: É um tipo de dados integral signed de 32 bits que pode representar valores de -2.147.483.648 a 2.147.483.647. Por exemplo:
```csharp
int meuInt = 2000000000;
```

- **uint**: É um tipo de dados integral unsigned de 32 bits que pode representar valores de 0 a 4.294.967.295. Por exemplo:
```csharp
uint meuUint = 4000000000;
```

- **long**: É um tipo de dados integral signed de 64 bits que pode representar valores de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807. Por exemplo:
```csharp
long meuLong = 8000000000000000000;
```

- **ulong**: É um tipo de dados integral unsigned de 64 bits que pode representar valores de 0 a 18.446.744.073.709.551.615. Por exemplo:
```csharp
ulong meuUlong = 16000000000000000000;
```

### Número Reais

Os tipos `float`, `double` e `decimal` em C# são todos usados para representar números com casas decimais, mas eles diferem em dois aspectos principais: a precisão (ou seja, quantas casas decimais eles podem representar com precisão) e o intervalo (ou seja, quão grande ou pequeno o número pode ser).

Aqui estão as definições desses tipos:

- **float**: É um tipo de dados de ponto flutuante de precisão simples que pode representar valores de aproximadamente ±1.5 x 10^-45 a ±3.4 x 10^38 com até 7 dígitos de precisão. Por exemplo:
```csharp
float meuFloat = 0.1234567F;
```

- **double**: É um tipo de dados de ponto flutuante de precisão dupla que pode representar valores de aproximadamente ±5.0 x 10^-324 a ±1.7 x 10^308 com até 15-16 dígitos de precisão. Por exemplo:
```csharp
double meuDouble = 0.1234567890123456;
```

- **decimal**: É um tipo de dados de ponto decimal que pode representar valores de aproximadamente ±1.0 x 10^-28 a ±7.9 x 10^28 com 28-29 dígitos de precisão. Este tipo é geralmente usado para cálculos financeiros e monetários, onde a precisão é muito importante. Por exemplo:
```csharp
decimal meuDecimal = 0.1234567890123456789012345678M;
```

### Boolean

O tipo `bool` em C# é um tipo de dados que pode representar um de dois valores: `true` (verdadeiro) ou `false` (falso). É como um interruptor de luz: o interruptor só pode estar em um de dois estados, ligado (`true`) ou desligado (`false`).

Aqui estão alguns exemplos de como você pode usar o tipo `bool` em C#:

```csharp
bool estaChovendo = true; // A variável 'estaChovendo' é definida como verdadeira
if (estaChovendo)
{
    Console.WriteLine("Melhor levar um guarda-chuva!");
}
```

Neste exemplo, a variável `estaChovendo` é do tipo `bool` e é definida como `true`. A instrução `if` verifica se `estaChovendo` é `true` e, se for, imprime a mensagem "Melhor levar um guarda-chuva!".

```csharp
bool temSol = false; // A variável 'temSol' é definida como falsa
if (!temSol)
{
    Console.WriteLine("Hoje não precisamos de protetor solar.");
}
```

Neste outro exemplo, a variável `temSol` é do tipo `bool` e é definida como `false`. A instrução `if` verifica se `temSol` é `false` (o operador `!` inverte o valor de `temSol`) e, se for, imprime a mensagem "Hoje não precisamos de protetor solar.".

### Char

O tipo `char` em C# é usado para representar um único caractere Unicode. É como uma pequena caixa que pode conter apenas um caractere.

Aqui estão alguns exemplos de como você pode usar o tipo `char` em C#:

```csharp
char minhaLetra = 'A'; // A variável 'minhaLetra' armazena o caractere 'A'
Console.WriteLine(minhaLetra); // Imprime "A"

char meuNumero = '1'; // A variável 'meuNumero' armazena o caractere '1'
Console.WriteLine(meuNumero); // Imprime "1"

char meuSimbolo = '$'; // A variável 'meuSimbolo' armazena o caractere '$'
Console.WriteLine(meuSimbolo); // Imprime "$"
```

Nestes exemplos, `minhaLetra`, `meuNumero` e `meuSimbolo` são variáveis do tipo `char` que armazenam os caracteres `'A'`, `'1'` e `'$'`, respectivamente. Quando imprimimos essas variáveis, vemos os caracteres que elas armazenam na tela.

É importante notar que os valores do tipo `char` devem ser cercados por aspas simples (`'`), não aspas duplas (`"`).

### String

O tipo `string` em C# é usado para representar uma sequência de caracteres. É como uma linha de caixas, onde cada caixa pode conter um caractere.

Aqui estão alguns exemplos de como você pode usar o tipo `string` em C#:

```csharp
string meuNome = "João"; // A variável 'meuNome' armazena a string "João"
Console.WriteLine(meuNome); // Imprime "João"

string minhaFrase = "Olá, mundo!"; // A variável 'minhaFrase' armazena a string "Olá, mundo!"
Console.WriteLine(minhaFrase); // Imprime "Olá, mundo!"

string vazia = ""; // A variável 'vazia' armazena uma string vazia
Console.WriteLine(vazia); // Não imprime nada
```

Nestes exemplos, `meuNome`, `minhaFrase` e `vazia` são variáveis do tipo `string` que armazenam as strings `"João"`, `"Olá, mundo!"` e `""` (uma string vazia), respectivamente. Quando imprimimos essas variáveis, vemos as strings que elas armazenam na tela.

É importante notar que os valores do tipo `string` devem ser cercados por aspas duplas (`"`), não aspas simples (`'`).


### Object
Em C#, `Object` é o tipo base para todos os outros tipos. É a classe raiz na hierarquia de classes do .NET, o que significa que todos os tipos, sejam eles primitivos ou complexos, são derivados do tipo `Object`.

Imagine que `Object` é como uma caixa grande onde todas as outras caixas (ou seja, tipos) podem caber. Independentemente do tamanho ou forma da caixa menor, ela sempre caberá na caixa grande.

Aqui estão alguns exemplos de como você pode usar o tipo `Object` em C#:

```csharp
Object minhaCaixa1 = "Olá, mundo!"; // A variável 'minhaCaixa1' armazena uma string
Console.WriteLine(minhaCaixa1); // Imprime "Olá, mundo!"

Object minhaCaixa2 = 12345; // A variável 'minhaCaixa2' armazena um inteiro
Console.WriteLine(minhaCaixa2); // Imprime "12345"

Object minhaCaixa3 = true; // A variável 'minhaCaixa3' armazena um valor booleano
Console.WriteLine(minhaCaixa3); // Imprime "True"
```

Nestes exemplos, `minhaCaixa1`, `minhaCaixa2` e `minhaCaixa3` são variáveis do tipo `Object` que armazenam uma string, um inteiro e um valor booleano, respectivamente. Quando imprimimos essas variáveis, vemos os valores que elas armazenam na tela.

### Nullabel Types
Os **tipos nullable** em C# são usados para representar valores que podem ser `null`. Eles são úteis quando você quer representar a ausência de um valor.

Por padrão, os tipos de valor em C# (como `int`, `bool`, `char`, etc.) não podem ser `null`. No entanto, às vezes você pode querer representar a ausência de um valor. Por exemplo, se você tem uma variável que representa a idade de uma pessoa, você pode querer ser capaz de representar o fato de que a idade da pessoa é desconhecida.

Para fazer isso, você pode usar um tipo nullable. Você cria um tipo nullable adicionando um `?` após o tipo de valor. Por exemplo, `int?` é um tipo nullable que pode conter um `int` ou `null`.

Aqui estão alguns exemplos de como você pode usar tipos nullable em C#:

```csharp
int? minhaIdade = null; // A variável 'minhaIdade' é definida como null
Console.WriteLine(minhaIdade); // Imprime ""

minhaIdade = 25;
Console.WriteLine(minhaIdade); // Imprime "25"
```

Neste exemplo, `minhaIdade` é uma variável do tipo `int?` que inicialmente armazena `null`. Quando imprimimos `minhaIdade`, não vemos nada na tela porque `minhaIdade` é `null`. Em seguida, atribuímos `25` a `minhaIdade` e imprimimos `minhaIdade` novamente, desta vez vemos `25` na tela.

## Alias

Os **alias** em C# são uma maneira de criar um novo nome para um tipo existente. Eles são úteis quando você quer usar um tipo que tem um nome longo ou complicado, mas prefere usar um nome mais curto ou mais fácil de lembrar.

Você cria um alias em C# usando a palavra-chave `using` seguida pelo nome do alias que você quer criar e o nome do tipo existente. Por exemplo:

```csharp
using Numero = System.Int32;
```

Neste exemplo, `Numero` é um alias para o tipo `System.Int32`. Agora, sempre que quisermos usar um `System.Int32`, podemos simplesmente usar `Numero` em vez disso.

Aqui está um exemplo de como você pode usar um alias em seu código:

```csharp
using Numero = System.Int32;

class Programa
{
    static void Main()
    {
        Numero meuNumero = 10;
        System.Console.WriteLine(meuNumero); // Imprime "10"
    }
}
```

Neste exemplo, `meuNumero` é uma variável do tipo `Numero`, que é um alias para `System.Int32`. Quando imprimimos `meuNumero`, vemos o valor `10` na tela.


## Valores padrão
Em C#, quando você declara uma variável mas não atribui um valor a ela, o compilador C# automaticamente atribui um **valor padrão** a essa variável. O valor padrão depende do tipo da variável.

Aqui estão os valores padrões para alguns dos tipos mais comuns em C#:

- Para tipos numéricos como `int`, `float`, `double`, etc., o valor padrão é `0`.
- Para o tipo `bool`, o valor padrão é `false`.
- Para o tipo `char`, o valor padrão é `\0` (um caractere nulo).
- Para tipos de referência como classes, interfaces, delegates, etc., o valor padrão é `null`.

Aqui estão alguns exemplos de como os valores padrões funcionam em C#:

```csharp
int meuInt;
Console.WriteLine(meuInt); // Imprime "0"

bool meuBool;
Console.WriteLine(meuBool); // Imprime "False"

char meuChar;
Console.WriteLine(meuChar == '\0'); // Imprime "True"

string minhaString;
Console.WriteLine(minhaString == null); // Imprime "True"
```

Nestes exemplos, `meuInt`, `meuBool`, `meuChar` e `minhaString` são declarados mas não são atribuídos valores. Quando imprimimos essas variáveis, vemos os valores padrões para seus respectivos tipos.

## Conversões

### Implícita
As **conversões implícitas** em C# são uma maneira de converter automaticamente um valor de um tipo para outro tipo sem perder informações. Elas são como traduzir uma frase de uma língua para outra sem perder o significado.

Por exemplo, você pode converter implicitamente um `int` para um `long` porque o `long` pode representar todos os valores que um `int` pode representar e mais. Aqui está um exemplo:

```csharp
int meuInt = 1000;
long meuLong = meuInt; // Conversão implícita de int para long
```

Neste exemplo, `meuInt` é uma variável do tipo `int` que armazena o valor `1000`. Em seguida, atribuímos `meuInt` a `meuLong`, que é uma variável do tipo `long`. Isso é uma conversão implícita de `int` para `long`.

No entanto, nem todas as conversões são possíveis de forma implícita. Por exemplo, você não pode converter implicitamente um `long` para um `int` porque um `long` pode representar valores que um `int` não pode representar. Tentar fazer isso resultaria em um erro de compilação.


### Explícita
As **conversões explícitas** em C#, também conhecidas como **castings**, são uma maneira de converter um valor de um tipo para outro tipo quando a conversão não é segura e pode resultar na perda de dados. É como tentar encaixar uma peça grande em uma caixa menor - você pode ter que cortar parte da peça para que ela caiba.

Por exemplo, você pode converter explicitamente um `double` para um `int`, mas você pode perder a parte decimal do `double`. Aqui está um exemplo:

```csharp
double meuDouble = 123.45;
int meuInt = (int)meuDouble; // Conversão explícita de double para int
Console.WriteLine(meuInt); // Imprime "123"
```

Neste exemplo, `meuDouble` é uma variável do tipo `double` que armazena o valor `123.45`. Em seguida, fazemos um casting de `meuDouble` para `int` e atribuímos o resultado a `meuInt`. Isso é uma conversão explícita de `double` para `int`. Quando imprimimos `meuInt`, vemos o valor `123` na tela, porque a parte decimal do `double` foi perdida na conversão.

As conversões explícitas são úteis quando você sabe o que está fazendo e está ciente de que a conversão pode resultar na perda de dados.


### Parse
O método **Parse** em C# é usado para converter uma string em um tipo de dados específico. É como traduzir uma frase de uma língua para outra.

Por exemplo, se você tem uma string que representa um número, como `"123"`, e quer usar esse número em um cálculo, você precisa converter a string em um número. Você pode fazer isso usando o método `Parse`.

Aqui estão alguns exemplos de como você pode usar o método `Parse` em C#:

```csharp
string minhaString = "123";
int meuInt = int.Parse(minhaString);
Console.WriteLine(meuInt + 1); // Imprime "124"
```

Neste exemplo, `minhaString` é uma string que contém o valor `"123"`. Usamos `int.Parse(minhaString)` para converter `minhaString` em um `int` e armazenamos o resultado na variável `meuInt`. Agora podemos usar `meuInt` em cálculos, como adicionar 1 a ele.

No entanto, é importante notar que o método `Parse` lançará uma exceção se a string que você está tentando analisar não puder ser convertida no tipo desejado. Por exemplo, `int.Parse("123abc")` resultará em uma exceção porque `"123abc"` não pode ser convertido em um `int`.


### Convert
O método **Convert** em C# é usado para converter um tipo de dados em outro. Ele é semelhante ao método `Parse`, mas é mais versátil porque pode lidar com uma variedade maior de conversões.

Por exemplo, você pode usar o método `Convert` para converter um `double` em um `int`. Aqui está um exemplo:

```csharp
double meuDouble = 123.45;
int meuInt = Convert.ToInt32(meuDouble);
Console.WriteLine(meuInt); // Imprime "123"
```

Neste exemplo, `meuDouble` é uma variável do tipo `double` que armazena o valor `123.45`. Usamos `Convert.ToInt32(meuDouble)` para converter `meuDouble` em um `int` e armazenamos o resultado na variável `meuInt`. Quando imprimimos `meuInt`, vemos o valor `123` na tela, porque a parte decimal do `double` foi perdida na conversão.

No entanto, é importante notar que, assim como o método `Parse`, o método `Convert` também lançará uma exceção se a conversão não for possível. Por exemplo, `Convert.ToInt32("123abc")` resultará em uma exceção porque `"123abc"` não pode ser convertido em um `int`.

## Operadores Aritméticos
Os **operadores aritméticos** em C# são usados para realizar operações matemáticas básicas, como adição, subtração, multiplicação, divisão e assim por diante. Eles são como os símbolos que você usa em uma equação matemática.

Aqui estão os operadores aritméticos mais comuns em C#:

- `+` (Adição): Adiciona dois números. Por exemplo:
```csharp
int soma = 5 + 3; // soma é igual a 8
```

- `-` (Subtração): Subtrai um número de outro. Por exemplo:
```csharp
int diferenca = 5 - 3; // diferenca é igual a 2
```

- `*` (Multiplicação): Multiplica dois números. Por exemplo:
```csharp
int produto = 5 * 3; // produto é igual a 15
```

- `/` (Divisão): Divide um número por outro. Por exemplo:
```csharp
int quociente = 10 / 2; // quociente é igual a 5
```

- `%` (Módulo): Retorna o resto de uma divisão. Por exemplo:
```csharp
int resto = 10 % 3; // resto é igual a 1
```

- `++` (Incremento): Aumenta o valor de uma variável em 1. Por exemplo:
```csharp
int x = 5;
x++; // x agora é igual a 6
```

- `--` (Decremento): Diminui o valor de uma variável em 1. Por exemplo:
```csharp
int x = 5;
x--; // x agora é igual a 4
```

## Operadores de atribuição
Os **operadores de atribuição** em C# são usados para atribuir valores a variáveis. O operador de atribuição mais básico é o `=`, que simplesmente atribui o valor à direita do operador à variável à esquerda do operador.

Aqui está um exemplo:

```csharp
int x = 10; // A variável 'x' recebe o valor 10
```

No entanto, existem também operadores de atribuição compostos que realizam uma operação aritmética e uma atribuição ao mesmo tempo. Aqui estão alguns exemplos:

- `+=`: Adiciona o valor à direita do operador ao valor da variável e atribui o resultado à variável. Por exemplo:
```csharp
x += 5; // É o mesmo que x = x + 5
```

- `-=`: Subtrai o valor à direita do operador do valor da variável e atribui o resultado à variável. Por exemplo:
```csharp
x -= 5; // É o mesmo que x = x - 5
```

- `*=`: Multiplica o valor da variável pelo valor à direita do operador e atribui o resultado à variável. Por exemplo:
```csharp
x *= 5; // É o mesmo que x = x * 5
```

- `/=`: Divide o valor da variável pelo valor à direita do operador e atribui o resultado à variável. Por exemplo:
```csharp
x /= 5; // É o mesmo que x = x / 5
```

- `%=`: Calcula o resto da divisão do valor da variável pelo valor à direita do operador e atribui o resultado à variável. Por exemplo:
```csharp
x %= 5; // É o mesmo que x = x % 5
```

Esses operadores de atribuição compostos podem tornar seu código mais conciso e fácil de ler.


## Operadores de comparação
Os **operadores de comparação** em C# são usados para comparar dois valores. Eles são como uma balança que pode dizer se um valor é maior, menor ou igual a outro valor.

Aqui estão os operadores de comparação mais comuns em C#:

- `==` (Igual a): Verifica se dois valores são iguais. Por exemplo:
```csharp
bool saoIguais = (5 == 5); // saoIguais é verdadeiro
```

- `!=` (Diferente de): Verifica se dois valores são diferentes. Por exemplo:
```csharp
bool saoDiferentes = (5 != 3); // saoDiferentes é verdadeiro
```

- `>` (Maior que): Verifica se o valor à esquerda do operador é maior que o valor à direita. Por exemplo:
```csharp
bool eMaior = (5 > 3); // eMaior é verdadeiro
```

- `<` (Menor que): Verifica se o valor à esquerda do operador é menor que o valor à direita. Por exemplo:
```csharp
bool eMenor = (3 < 5); // eMenor é verdadeiro
```

- `>=` (Maior ou igual a): Verifica se o valor à esquerda do operador é maior ou igual ao valor à direita. Por exemplo:
```csharp
bool eMaiorOuIgual = (5 >= 5); // eMaiorOuIgual é verdadeiro
```

- `<=` (Menor ou igual a): Verifica se o valor à esquerda do operador é menor ou igual ao valor à direita. Por exemplo:
```csharp
bool eMenorOuIgual = (5 <= 5); // eMenorOuIgual é verdadeiro
```

Esses operadores de comparação são frequentemente usados em instruções condicionais (`if`, `else if`, `while`, etc.) para controlar o fluxo do programa.


## Operadores Lógicos
Os **operadores lógicos** em C# são usados para combinar ou inverter valores booleanos. Eles são como as palavras "e", "ou" e "não" em uma frase.

Aqui estão os operadores lógicos mais comuns em C#:

- `&&` (E lógico): Retorna `true` se ambos os operandos forem `true`. Por exemplo:
```csharp
bool eVerdade = (5 > 3) && (2 < 3); // eVerdade é verdadeiro porque ambas as condições são verdadeiras
```

- `||` (OU lógico): Retorna `true` se pelo menos um dos operandos for `true`. Por exemplo:
```csharp
bool ouVerdade = (5 > 3) || (2 > 3); // ouVerdade é verdadeiro porque pelo menos uma das condições é verdadeira
```

- `!` (NÃO lógico): Inverte o valor booleano. Por exemplo:
```csharp
bool naoVerdade = !(5 > 3); // naoVerdade é falso porque a condição (5 > 3) é verdadeira, mas nós a invertemos
```

Esses operadores lógicos são frequentemente usados em instruções condicionais (`if`, `else if`, `while`, etc.) para combinar ou inverter condições.

## Estruturas Condicionais

As estruturas condicionais permitem que o código seja executado com base em uma condição. As duas principais estruturas condicionais em C# são `if` e `switch`.

### If

A estrutura `if` permite que o código seja executado se uma determinada condição for verdadeira. Aqui está um exemplo:

```csharp
int x = 10;
if (x > 5)
{
    Console.WriteLine("x é maior que 5");
}
```

Neste exemplo, a mensagem "x é maior que 5" será impressa porque a condição `x > 5` é verdadeira.

### Switch

A estrutura `switch` permite que o código seja executado com base em vários casos. Aqui está um exemplo:

```csharp
int x = 10;
switch (x)
{
    case 5:
        Console.WriteLine("x é 5");
        break;
    case 10:
        Console.WriteLine("x é 10");
        break;
    default:
        Console.WriteLine("x não é 5 nem 10");
        break;
}
```

Neste exemplo, a mensagem "x é 10" será impressa porque `x` corresponde ao caso `10`.

## Loops

Os loops permitem que o código seja executado repetidamente. Os dois principais tipos de loops em C# são `for` e `while`.

### For

O loop `for` permite que o código seja executado um número específico de vezes. Aqui está um exemplo:

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

Neste exemplo, os números de 0 a 4 serão impressos.

### While

O loop `while` permite que o código seja executado enquanto uma condição for verdadeira. Aqui está um exemplo:

```csharp
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}
```

Neste exemplo, os números de 0 a 4 também serão impressos.

### Do/While
O loop `do/while` é uma estrutura de controle de fluxo em C# que permite que um bloco de código seja executado repetidamente. A diferença entre o loop `do/while` e o loop `while` é que o loop `do/while` verifica a condição **depois** de executar o bloco de código, garantindo que o bloco de código seja executado pelo menos uma vez.

Aqui está um exemplo de como o loop `do/while` funciona:

```csharp
int i = 0;
do
{
    Console.WriteLine(i);
    i++;
} while (i < 5);
```

Neste exemplo, os números de 0 a 4 serão impressos. O bloco de código dentro do loop `do/while` é executado primeiro, e então a condição `i < 5` é verificada. Se a condição for verdadeira, o bloco de código é executado novamente. Isso continua até que a condição se torne falsa.

