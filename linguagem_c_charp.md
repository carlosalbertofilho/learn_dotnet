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

