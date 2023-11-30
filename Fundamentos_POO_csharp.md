# Fundamentos da Orientação a Objetos em C#

A programação orientada a objetos (OOP) é um paradigma de programação baseado no conceito de "objetos", que podem conter dados e código: dados na forma de campos (muitas vezes conhecidos como atributos ou propriedades), e código, na forma de procedimentos (muitas vezes conhecidos como métodos).

## Conceitos fundamentais

Os quatro princípios fundamentais da OOP em C# são:

1. **Encapsulamento**: É o conceito de ocultar os detalhes de implementação e exibir apenas a funcionalidade ao usuário. Em C#, isso é alcançado usando classes e acessando modificadores.

2. **Herança**: É o conceito de criar uma nova classe usando as propriedades e métodos de uma classe existente. A nova classe é chamada de classe derivada e a classe existente é chamada de classe base.

3. **Polimorfismo**: É o conceito de usar métodos de diferentes maneiras. Em C#, existem dois tipos de polimorfismo: estático (ou sobrecarga de método) e dinâmico (ou substituição de método).

4. **Abstração**: É o conceito de ocultar detalhes internos e mostrar apenas a funcionalidade necessária. Em C#, isso é alcançado usando interfaces e classes abstratas.

# Classes e Objetos em C#

## Conceito

**Classes** e **Objetos** são dois dos conceitos fundamentais da programação orientada a objetos.

- Uma **Classe** é um modelo ou um plano que descreve as propriedades (atributos) e comportamentos (métodos) que um objeto do tipo da classe terá. É como um projeto para a criação de objetos.

- Um **Objeto** é uma instância de uma classe. Ele tem um estado e comportamento. O estado é definido pelos valores dos atributos e o comportamento é definido pelos métodos.

## Uso

Em C#, você define uma classe usando a palavra-chave `class`, seguida pelo nome da classe e um par de chaves `{}`. Dentro das chaves, você define os atributos e métodos da classe.

Para criar um objeto de uma classe, você usa a palavra-chave `new` seguida pelo nome da classe.

## Exemplo

Aqui está um exemplo simples de uma classe e um objeto em C#:

```csharp
// Definição da classe
public class Carro
{
    // Atributos
    public string Marca;
    public string Modelo;
    public int Ano;

    // Método
    public void Buzinar()
    {
        Console.WriteLine("Beep! Beep!");
    }
}

// Criação de um objeto
Carro meuCarro = new Carro();
meuCarro.Marca = "Toyota";
meuCarro.Modelo = "Corolla";
meuCarro.Ano = 2020;

// Uso do objeto
Console.WriteLine(meuCarro.Marca);  // Saída: "Toyota"
meuCarro.Buzinar();  // Saída: "Beep! Beep!"
```

Neste exemplo, `Carro` é uma classe com três atributos (`Marca`, `Modelo` e `Ano`) e um método (`Buzinar`). `meuCarro` é um objeto da classe `Carro`. Ele tem seu próprio estado (definido pelos valores dos atributos) e comportamento (definido pelo método `Buzinar`).

# Encapsulamento em C#

## Conceito

O **Encapsulamento** é um dos quatro princípios fundamentais da programação orientada a objetos. Ele se refere à ideia de agrupar dados e métodos que manipulam esses dados em uma única unidade, que é a classe. Isso ajuda a ocultar os detalhes internos de como a classe funciona e expõe apenas o que é necessário.

O encapsulamento também permite que você controle o acesso aos dados em sua classe através do uso de modificadores de acesso, como `public`, `private` e `protected`.

- `public`: O membro é acessível de qualquer lugar.
- `private`: O membro só é acessível dentro da própria classe.
- `protected`: O membro é acessível dentro da própria classe e por classes derivadas.
- `internal`: O membro é acessível a todas as classes e métodos dentro do mesmo assembly (ou seja, o mesmo projeto ou DLL), mas não é acessível a classes e métodos em diferentes assemblies.

## Uso

Em C#, você pode usar propriedades para fornecer um meio de ler, escrever ou calcular o valor de um campo privado. Propriedades podem ser de leitura-gravação, somente leitura ou somente gravação.

## Exemplo

Aqui está um exemplo simples de encapsulamento em C#:

```csharp
public class Pessoa
{
    // Campo privado
    private string nome;

    // Propriedade pública para obter e definir o valor do campo privado
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
}

// Uso da classe Pessoa
Pessoa pessoa = new Pessoa();
pessoa.Nome = "João";  // Define o nome
Console.WriteLine(pessoa.Nome);  // Obtém e imprime o nome
```

Neste exemplo, `Pessoa` é uma classe com um campo privado `nome` e uma propriedade pública `Nome`. A propriedade `Nome` permite que você obtenha e defina o valor do campo `nome`. Isso é um exemplo de encapsulamento porque o campo `nome` está oculto e só pode ser acessado através da propriedade `Nome`.

# Abstração em C#

## Conceito

A **Abstração** é um dos quatro princípios fundamentais da programação orientada a objetos. Ela se refere à prática de esconder os detalhes de implementação e exibir apenas a funcionalidade ao usuário. Em outras palavras, é a redução de um conjunto de observações em um conjunto simplificado de características.

Em C#, a abstração é alcançada usando classes abstratas e interfaces.

- Uma **classe abstrata** é uma classe que não pode ser instanciada e é sempre usada como uma classe base.
- Uma **interface** é uma referência tipo. É um conjunto de definições de métodos abstratos (sem corpo).

## Uso

Em C#, você define uma classe abstrata usando a palavra-chave `abstract`. Você pode ter métodos abstratos (que não têm corpo) e métodos concretos (que têm corpo) em uma classe abstrata.

Uma interface é definida usando a palavra-chave `interface` e pode conter apenas a assinatura de métodos, eventos, propriedades ou indexadores.

## Exemplo

Aqui está um exemplo simples de abstração em C#:

```csharp
// Classe abstrata
public abstract class Animal
{
    public abstract void animalSound(); // Método abstrato (não tem corpo)

    public void sleep() // Método concreto (tem corpo)
    {
        Console.WriteLine("Zzz");
    }
}

// Subclasse (herda de Animal)
public class Porco : Animal
{
    public override void animalSound() // Implementa o método abstrato
    {
        Console.WriteLine("O porco diz: wee wee");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Porco meuPorco = new Porco(); // Cria um objeto Porco
        meuPorco.animalSound();  // Chama o método abstrato
        meuPorco.sleep();  // Chama o método concreto
    }
}
```

Neste exemplo, temos uma classe abstrata `Animal` com um método abstrato `animalSound()` e um método concreto `sleep()`. A classe `Porco` herda da classe `Animal` e implementa o método abstrato `animalSound()`. No método `Main`, criamos um objeto `Porco` e chamamos os métodos `animalSound()` e `sleep()`. Isso demonstra a abstração porque estamos chamando métodos em um objeto `Porco` sem precisar entender os detalhes internos de como esses métodos são implementados.

# Herança em C#

## Conceito

A **Herança** é um dos quatro princípios fundamentais da programação orientada a objetos. Ela permite que você crie uma nova classe que reutiliza, estende e modifica o comportamento definido em outra classe. A classe cujos membros são herdados é chamada de classe base, e a classe que herda esses membros é chamada de classe derivada.

## Uso

Em C#, a herança é implementada usando o símbolo `:`. A classe derivada é escrita à esquerda e a classe base à direita.

## Exemplo

Aqui está um exemplo simples de herança em C#:

```csharp
// Classe base
public class Veiculo
{
    public string Marca { get; set; }

    public void Honk()
    {
        Console.WriteLine("Beep! Beep!");
    }
}

// Classe derivada
public class Carro : Veiculo
{
    public string Modelo { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Cria um objeto Carro
        Carro meuCarro = new Carro();

        // Define as propriedades
        meuCarro.Marca = "Toyota";
        meuCarro.Modelo = "Corolla";

        // Chama o método da classe base
        meuCarro.Honk();

        // Imprime as propriedades
        Console.WriteLine($"{meuCarro.Marca} {meuCarro.Modelo}");
    }
}
```

Neste exemplo, `Veiculo` é a classe base e `Carro` é a classe derivada. A classe `Carro` herda os membros da classe `Veiculo` e adiciona um novo membro `Modelo`. No método `Main`, criamos um objeto `Carro`, definimos suas propriedades, chamamos o método `Honk` e imprimimos as propriedades. Isso demonstra a herança porque estamos usando membros definidos na classe base `Veiculo` a partir de um objeto da classe derivada `Carro`.


# Polimorfismo em C#

## Conceito

O **Polimorfismo** é um dos quatro princípios fundamentais da programação orientada a objetos. Ele permite que as classes derivadas tenham métodos com o mesmo nome que os métodos na classe base, mas com implementações diferentes. Isso significa que você pode usar um único tipo de interface para representar diferentes tipos de ações.

## Uso

Em C#, o polimorfismo é implementado usando a palavra-chave `virtual` na classe base para indicar que um método pode ser substituído por classes derivadas. Na classe derivada, usamos a palavra-chave `override` para fornecer uma nova implementação do método.

## Exemplo

Aqui está um exemplo simples de polimorfismo em C#:

```csharp
// Classe base
public class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("O animal faz um som");
    }
}

// Classe derivada
public class Porco : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("O porco diz: wee wee");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal meuAnimal = new Animal();  // Cria um objeto Animal
        Animal meuPorco = new Porco();  // Cria um objeto Porco

        meuAnimal.animalSound();  // Saída: "O animal faz um som"
        meuPorco.animalSound();  // Saída: "O porco diz: wee wee"
    }
}
```

Neste exemplo, `Animal` é a classe base e `Porco` é a classe derivada. A classe `Animal` tem um método `animalSound()` que é substituído na classe `Porco`. No método `Main`, criamos um objeto `Animal` e um objeto `Porco` e chamamos o método `animalSound()` em ambos. Isso demonstra o polimorfismo porque o mesmo método `animalSound()` está fazendo coisas diferentes dependendo do tipo de objeto que está chamando.

# Using e Dispose

Em C#, `using` e `Dispose` são usados para lidar com recursos não gerenciados, como arquivos, conexões de banco de dados, soquetes de rede, etc. Esses recursos não são gerenciados pelo coletor de lixo do .NET e precisam ser liberados explicitamente quando não são mais necessários.

### Using

A declaração `using` é uma maneira conveniente de garantir que um objeto IDisposable seja limpo corretamente. Isso é equivalente a usar um bloco `try/finally`.

Aqui está um exemplo de como usar a declaração `using`:

```csharp
using (StreamReader sr = new StreamReader("file.txt"))
{
    // Operações com o objeto sr.
}
```

Neste exemplo, o objeto `StreamReader` `sr` é automaticamente descartado assim que o controle sai do bloco `using`. Isso é equivalente ao seguinte código:

```csharp
StreamReader sr = null;
try
{
    sr = new StreamReader("file.txt");
    // Operações com o objeto sr.
}
finally
{
    if (sr != null)
        sr.Dispose();
}
```

### Dispose

O método `Dispose` é usado para liberar recursos não gerenciados. Ele é geralmente chamado dentro de um bloco `finally` ou de uma declaração `using`.

Aqui está um exemplo de como implementar o método `Dispose` em uma classe:

```csharp
public class MyClass : IDisposable
{
    private bool disposed = false;

    // Método Dispose para limpar os recursos não gerenciados.
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Libere recursos gerenciados aqui.
            }

            // Libere recursos não gerenciados aqui.

            disposed = true;
        }
    }

    // Destrutor da classe.
    ~MyClass()
    {
        Dispose(false);
    }
}
```

Neste exemplo, a classe `MyClass` implementa a interface `IDisposable` e fornece uma implementação para o método `Dispose`. Quando o método `Dispose` é chamado, ele libera todos os recursos não gerenciados e suprime a finalização do objeto, o que significa que o destrutor da classe não será chamado pelo coletor de lixo.

# Classes Estáticas

Em C#, uma classe estática é uma classe que não pode ser instanciada ou herdada e seus membros podem ser acessados diretamente. Isso significa que você não precisa criar um objeto da classe para acessar seus membros. Uma classe estática permanece na memória pelo tempo de vida do aplicativo que a contém e não pode ser coletada como lixo.

### Uso de Classes Estáticas

As classes estáticas são úteis quando você tem dados ou comportamentos que não estão associados a instâncias específicas de uma classe. Por exemplo, se você tiver uma biblioteca de funções matemáticas, poderá implementá-las como métodos estáticos dentro de uma classe estática.

Aqui está um exemplo de como definir e usar uma classe estática:

```csharp
public static class MinhaClasseEstatica
{
    public static int MeuMetodoEstatico(int x, int y)
    {
        return x + y;
    }
}

// Uso da classe estática
int resultado = MinhaClasseEstatica.MeuMetodoEstatico(5, 10);
```

Neste exemplo, `MinhaClasseEstatica` é uma classe estática que contém um método estático `MeuMetodoEstatico`. Este método pode ser chamado diretamente usando o nome da classe, sem a necessidade de criar uma instância da classe.

# Classes Seladas

Em C#, uma classe selada é uma classe que não pode ser herdada. Em outras palavras, nenhuma outra classe pode estender uma classe selada. Isso é útil quando você quer restringir a herança para evitar que outras classes alterem a funcionalidade de sua classe.

### Uso de Classes Seladas

Para criar uma classe selada, você usa a palavra-chave `sealed`:

```csharp
public sealed class MinhaClasseSelada
{
    public int MeuMetodo(int x, int y)
    {
        return x + y;
    }
}
```

Neste exemplo, `MinhaClasseSelada` é uma classe selada que contém um método `MeuMetodo`. Nenhuma outra classe pode estender `MinhaClasseSelada`.

Tentar herdar de uma classe selada resultará em um erro de compilação:

```csharp
public class MinhaOutraClasse : MinhaClasseSelada // Erro de compilação
{
}
```

# Partial Class

