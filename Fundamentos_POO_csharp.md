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

Em C#, uma classe parcial é uma classe cuja definição pode ser dividida em várias partes ou arquivos. Cada parte contém uma seção da definição da classe, e todas as partes são combinadas quando o aplicativo é compilado.

### Uso de Classes Parciais

A palavra-chave `partial` é usada para definir uma classe parcial:

```csharp
// Arquivo MinhaClasseParcial1.cs
public partial class MinhaClasseParcial
{
    public void Metodo1()
    {
        // Implementação do Metodo1.
    }
}

// Arquivo MinhaClasseParcial2.cs
public partial class MinhaClasseParcial
{
    public void Metodo2()
    {
        // Implementação do Metodo2.
    }
}
```

Neste exemplo, `MinhaClasseParcial` é uma classe parcial que é definida em dois arquivos, `MinhaClasseParcial1.cs` e `MinhaClasseParcial2.cs`. Cada arquivo contém uma parte da definição da classe. Quando o aplicativo é compilado, as duas partes são combinadas em uma única classe.

As classes parciais são úteis quando trabalhamos com código gerado automaticamente (como o código gerado por designers de formulários), pois permitem que você estenda a classe em um arquivo separado sem modificar o arquivo gerado automaticamente.

# Interfaces em C#

Em C#, uma interface é um tipo de referência que define um contrato para classes, structs e outras interfaces. Ela especifica um conjunto de membros que devem ser implementados. Uma interface pode conter declarações de métodos, propriedades, eventos e indexadores, mas não pode conter a implementação desses membros.

### Uso de Interfaces

Para definir uma interface, usamos a palavra-chave `interface`:

```csharp
public interface IMinhaInterface
{
    void MeuMetodo();
}
```

Neste exemplo, `IMinhaInterface` é uma interface que declara um método chamado `MeuMetodo`.

Para implementar uma interface, usamos a palavra-chave `:` seguida pelo nome da interface:

```csharp
public class MinhaClasse : IMinhaInterface
{
    public void MeuMetodo()
    {
        // Implementação do MeuMetodo.
    }
}
```

Neste exemplo, `MinhaClasse` é uma classe que implementa `IMinhaInterface` e fornece uma implementação para `MeuMetodo`.

As interfaces são úteis quando queremos garantir que uma classe ou struct forneça um conjunto específico de funcionalidades, ou quando queremos permitir que um objeto seja manipulado como um tipo específico de objeto, independentemente de sua classe ou struct real.


# Classes Abstradas

Em C#, uma classe abstrata é uma classe que não pode ser instanciada e é destinada a ser herdada por outras classes. Ela pode conter métodos abstratos (sem corpo) que devem ser implementados pelas classes derivadas, bem como métodos não abstratos (com corpo).

### Uso de Classes Abstratas

Para criar uma classe abstrata, usamos a palavra-chave `abstract`:

```csharp
public abstract class MinhaClasseAbstrata
{
    public abstract void MeuMetodoAbstrato();

    public void MeuMetodoNaoAbstrato()
    {
        // Implementação do MeuMetodoNaoAbstrato.
    }
}
```

Neste exemplo, `MinhaClasseAbstrata` é uma classe abstrata que declara um método abstrato chamado `MeuMetodoAbstrato` e um método não abstrato chamado `MeuMetodoNaoAbstrato`.

Para herdar de uma classe abstrata, usamos a palavra-chave `:` seguida pelo nome da classe abstrata. Também precisamos fornecer implementações para todos os métodos abstratos:

```csharp
public class MinhaClasse : MinhaClasseAbstrata
{
    public override void MeuMetodoAbstrato()
    {
        // Implementação do MeuMetodoAbstrato.
    }
}
```

Neste exemplo, `MinhaClasse` é uma classe que herda de `MinhaClasseAbstrata` e fornece uma implementação para `MeuMetodoAbstrato`.

As classes abstratas são úteis quando temos um conjunto de classes que compartilham funcionalidades comuns, mas também têm comportamentos específicos que precisam ser implementados de maneira diferente por cada classe.

# Upcast e Downcast

**Upcasting** e **Downcasting** são conceitos importantes na programação orientada a objetos e estão relacionados à herança e ao polimorfismo.

- **Upcasting**: É o processo de converter uma referência de tipo de subclasse em uma referência de tipo de superclasse. Isso é feito automaticamente em C#, pois uma subclasse é um tipo especializado da superclasse, então não há risco de perda de dados. O upcasting é útil quando você quer usar um método ou propriedade que está disponível na superclasse, mas não na subclasse.

- **Downcasting**: É o processo de converter uma referência de tipo de superclasse em uma referência de tipo de subclasse. Isso deve ser feito explicitamente em C#, pois há um risco de perda de dados. O downcasting é útil quando você sabe que o objeto é de um tipo de subclasse e você quer usar um método ou propriedade que está disponível apenas na subclasse.

## Exemplo

Aqui está um exemplo simples de upcasting e downcasting em C#:

```csharp
// Classe base
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Comendo...");
    }
}

// Classe derivada
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Latindo...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog rex = new Dog();

        // Upcasting
        Animal animal = rex;
        animal.Eat();  // Saída: "Comendo..."

        // Downcasting
        Dog dog = (Dog)animal;
        dog.Bark();  // Saída: "Latindo..."
    }
}
```

Neste exemplo, `Dog` é uma subclasse de `Animal`. No método `Main`, criamos um objeto `Dog` chamado `rex`. Em seguida, fazemos o upcasting de `rex` para um `Animal` e chamamos o método `Eat()`. Depois, fazemos o downcasting do `Animal` de volta para um `Dog` e chamamos o método `Bark()`. Isso demonstra como o upcasting e o downcasting podem ser usados para acessar diferentes métodos dependendo do tipo de referência.

# Comparação de Objetos em C#

A comparação de objetos é um conceito fundamental na programação orientada a objetos. Em C#, existem duas maneiras principais de comparar objetos: comparação de referência e comparação de valor.

- **Comparação de Referência**: Quando dois objetos são comparados usando o operador `==`, o C# verifica se as duas variáveis apontam para o mesmo objeto na memória, não se seus conteúdos são iguais. Isso é chamado de comparação de referência.

- **Comparação de Valor**: Se você quiser comparar se dois objetos têm o mesmo valor, você precisa implementar isso em sua classe. Isso é geralmente feito sobrescrevendo os métodos `Equals` e `GetHashCode` da classe base `Object`.

## Uso

Para implementar a comparação de valor em sua classe, você precisa sobrescrever os métodos `Equals` e `GetHashCode`. O método `Equals` é usado para comparar dois objetos para igualdade, e o método `GetHashCode` é usado para retornar um código hash único para o objeto.

## Exemplo

Aqui está um exemplo simples de como a comparação de objetos é feita em C#:

```csharp
public class Pessoa
{
    public string Nome { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Pessoa outraPessoa = (Pessoa)obj;
        return Nome == outraPessoa.Nome;  // Compara os nomes para igualdade
    }

    public override int GetHashCode()
    {
        return Nome.GetHashCode();  // Retorna o código hash do nome
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa { Nome = "João" };
        Pessoa pessoa2 = new Pessoa { Nome = "João" };

        Console.WriteLine(pessoa1 == pessoa2);  // Saída: "False" (comparação de referência)
        Console.WriteLine(pessoa1.Equals(pessoa2));  // Saída: "True" (comparação de valor)
    }
}
```

Neste exemplo, `Pessoa` é uma classe com um campo `Nome` e métodos `Equals` e `GetHashCode` sobrescritos. No método `Main`, criamos dois objetos `Pessoa` com o mesmo nome. Quando usamos o operador `==` para compará-los, ele retorna `False` porque está fazendo uma comparação de referência. Quando usamos o método `Equals` para compará-los, ele retorna `True` porque está fazendo uma comparação de valor.

# Delegates em C#

Um **Delegate** em C# é semelhante a um ponteiro para uma função, em C ou C++. Um delegate é um tipo de referência que pode ser usado para encapsular um método nomeado ou anônimo. Delegates são especialmente usados para implementar eventos e o conceito de callbacks.

## Uso

Delegates são usados onde você espera algum tipo de comportamento, mas não sabe qual método deve ser chamado. Você precisa apenas saber o retorno e os tipos de parâmetros para usar um delegate.

Para declarar um delegate, você usa a palavra-chave `delegate` seguida pela assinatura do método.

## Exemplo

Aqui está um exemplo simples de como os delegates são usados em C#:

```csharp
// Declaração do delegate
public delegate void MeuDelegate(string msg);

// Método que corresponde à assinatura do delegate
public static void MeuMetodo(string mensagem)
{
    Console.WriteLine(mensagem);
}

class Program
{
    static void Main(string[] args)
    {
        // Criação de uma instância do delegate
        MeuDelegate del = new MeuDelegate(MeuMetodo);

        // Invocação do delegate
        del("Olá, Mundo!");
    }
}
```

Neste exemplo, `MeuDelegate` é um delegate que encapsula um método que recebe um único parâmetro do tipo `string` e não retorna nada. `MeuMetodo` é um método que corresponde à assinatura do delegate. No método `Main`, criamos uma instância do delegate `del` e associamos a ela o método `MeuMetodo`. Em seguida, invocamos o delegate, que chama `MeuMetodo` e imprime "Olá, Mundo!".

# Events

**Events** em C# são uma maneira de fornecer notificações a outros classes quando um determinado evento acontece. Um evento é uma ação especial que pode ser gerada por um objeto (conhecido como o publicador do evento) com base em alterações em seu estado e é notificado a outros objetos (conhecidos como assinantes).

Os eventos usam o conceito de delegados para fornecer uma assinatura de evento que será usada para chamar o método de evento.

## Uso

Para declarar um evento dentro de uma classe, você usa a palavra-chave `event` seguida pelo tipo de delegate para o evento e o nome do evento.

Os assinantes de um evento podem se inscrever no evento usando o operador `+=` e podem cancelar a inscrição usando o operador `-=`.

## Exemplo

Aqui está um exemplo simples de como os eventos são usados em C#:

```csharp
// Delegate para o evento
public delegate void MudancaEventHandler();

// Classe que publica o evento
public class Publicador
{
    // Evento
    public event MudancaEventHandler Mudanca;

    // Método que dispara o evento
    public void DispararEvento()
    {
        Mudanca?.Invoke();
    }
}

// Classe que se inscreve no evento
public class Assinante
{
    public void Inscrever(Publicador pub)
    {
        pub.Mudanca += ResponderAoEvento;
    }

    // Método que será chamado quando o evento for disparado
    private void ResponderAoEvento()
    {
        Console.WriteLine("O evento foi disparado!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Publicador pub = new Publicador();
        Assinante ass = new Assinante();

        ass.Inscrever(pub);

        pub.DispararEvento();  // Saída: "O evento foi disparado!"
    }
}
```

Neste exemplo, `Publicador` é uma classe que define um evento chamado `Mudanca`. `Assinante` é uma classe que se inscreve no evento `Mudanca` e define um método `ResponderAoEvento` que será chamado quando o evento for disparado. No método `Main`, criamos um objeto `Publicador` e um objeto `Assinante`, inscrevemos o `Assinante` no evento `Mudanca` do `Publicador` e então disparamos o evento.

# Generics 

**Generics** são um recurso de C# que permite que você defina classes, interfaces e métodos com um marcador de posição para o tipo de dados. Isso permite que você crie código que é flexível e reutilizável para vários tipos de dados, sem perder a segurança de tipos.

## Uso

Para definir uma classe, interface ou método genérico, você usa a sintaxe `<T>`, onde `T` é um marcador de posição para o tipo de dados. Você pode então usar `T` em seu código como se fosse qualquer outro tipo de dados.

## Uso do `where`

A palavra-chave `where` em C# é usada para especificar restrições nos tipos que podem ser usados como argumentos para um tipo de parâmetro em uma definição de método genérico, delegado, interface, classe ou estrutura genérica.

Por exemplo, você pode restringir um tipo genérico `T` para ser uma classe (usando `where T : class`), para ter um construtor sem parâmetros (usando `where T : new()`), para implementar uma interface específica (usando `where T : IMinhaInterface`), ou para herdar de uma classe específica (usando `where T : MinhaClasse`).

## Exemplo

Aqui está um exemplo simples de como os generics e a palavra-chave `where` são usados em C#:

```csharp
// Classe genérica com restrição de tipo
public class MinhaClasse<T> where T : new()
{
    T valor = new T();

    public void EscreverValor()
    {
        Console.WriteLine(valor);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criação de um objeto da classe genérica com int
        MinhaClasse<int> meuInt = new MinhaClasse<int>();
        meuInt.EscreverValor();  // Saída: "0"

        // Criação de um objeto da classe genérica com string
        MinhaClasse<string> minhaString = new MinhaClasse<string>();
        minhaString.EscreverValor();  // Saída: ""
    }
}
```

Neste exemplo, `MinhaClasse` é uma classe genérica que tem um campo do tipo `T`. A restrição `where T : new()` significa que `T` deve ter um construtor sem parâmetros. No método `Main`, criamos dois objetos `MinhaClasse`: um que usa `int` para `T` e outro que usa `string` para `T`. Isso demonstra como os generics e a palavra-chave `where` podem ser usados para criar código que funciona com vários tipos de dados e ainda mantém a segurança de tipos.

# Listas 

Uma **Lista** em C# é uma coleção fortemente tipada de objetos que pode ser acessada por índice. Ela pertence à biblioteca `System.Collections.Generic` do .NET Framework. Uma lista fornece funcionalidades para adicionar, remover ou encontrar itens em uma coleção.

## Uso

Para usar uma lista em C#, você precisa instanciá-la com o tipo de dados que ela armazenará. Você pode adicionar itens à lista usando o método `Add()`, remover itens usando o método `Remove()`, e acessar itens usando o operador de indexação `[]`.

## Exemplo

Aqui está um exemplo simples de como as listas são usadas em C#:

```csharp
// Criação de uma lista de inteiros
List<int> numeros = new List<int>();

// Adicionando itens à lista
numeros.Add(1);
numeros.Add(2);
numeros.Add(3);

// Acessando itens da lista
Console.WriteLine(numeros[0]);  // Saída: "1"

// Removendo um item da lista
numeros.Remove(2);

// Iterando sobre a lista
foreach (int numero in numeros)
{
    Console.WriteLine(numero);  // Saída: "1" e "3"
}
```

Neste exemplo, criamos uma lista de inteiros chamada `numeros`. Adicionamos alguns números à lista, acessamos um número pelo índice, removemos um número e iteramos sobre a lista para imprimir todos os números. Isso demonstra como as listas podem ser usadas para armazenar e manipular uma coleção de itens em C#.

## IEnumerable

**IEnumerable** é uma interface em C# que define um método, `GetEnumerator`, que retorna um objeto `IEnumerator`. Esta interface permite que um objeto seja iterado (ou "enumerado") usando uma construção `foreach`.

A interface `IEnumerator` fornece os métodos para iterar através de uma coleção, especificamente `MoveNext`, `Reset` e a propriedade `Current`.

### Uso

Qualquer classe ou estrutura que implementa a interface `IEnumerable` pode ser usada com uma construção `foreach`. As classes de coleção no .NET Framework, como `List` e `Array`, implementam `IEnumerable`.

### Exemplo

Aqui está um exemplo simples de como a interface `IEnumerable` é usada em C#:

```csharp
// Classe que implementa IEnumerable
public class ColecaoNumeros : IEnumerable
{
    int[] numeros = { 1, 2, 3, 4, 5 };

    public IEnumerator GetEnumerator()
    {
        foreach (int numero in numeros)
        {
            yield return numero;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ColecaoNumeros colecao = new ColecaoNumeros();

        // Iterando sobre a coleção com foreach
        foreach (int numero in colecao)
        {
            Console.WriteLine(numero);  // Saída: "1", "2", "3", "4", "5"
        }
    }
}
```

Neste exemplo, `ColecaoNumeros` é uma classe que implementa `IEnumerable`. Ela contém um array de inteiros e implementa o método `GetEnumerator` para retornar cada número no array. No método `Main`, criamos um objeto `ColecaoNumeros` e usamos um loop `foreach` para iterar sobre cada número na coleção. Isso demonstra como a interface `IEnumerable` pode ser usada para permitir a iteração sobre uma coleção personalizada em C#.

## ICollection

**ICollection** é uma interface em C# que define métodos e propriedades gerais para coleções. Ela pertence ao namespace `System.Collections.Generic` do .NET Framework e é a base para todas as classes de coleção genéricas no .NET.

A interface `ICollection<T>` estende a interface `IEnumerable<T>` e adiciona propriedades e métodos que permitem adicionar e remover itens, limpar a coleção, verificar se um item está na coleção, copiar a coleção para um array e obter o número de itens na coleção.

### Uso

Para usar a interface `ICollection<T>`, você precisa implementá-la em sua classe ou usar uma das classes de coleção fornecidas pelo .NET Framework que já implementam `ICollection<T>`, como `List<T>`, `HashSet<T>` e `Dictionary<TKey, TValue>`.

### Exemplo

Aqui está um exemplo simples de como a interface `ICollection` é usada em C#:

```csharp
// Criação de uma coleção de inteiros
ICollection<int> numeros = new List<int>();

// Adicionando itens à coleção
numeros.Add(1);
numeros.Add(2);
numeros.Add(3);

// Verificando se um item está na coleção
bool contemDois = numeros.Contains(2);  // Retorna true

// Removendo um item da coleção
numeros.Remove(2);

// Obtendo o número de itens na coleção
int count = numeros.Count;  // Retorna 2

// Limpar a coleção
numeros.Clear();
```

Neste exemplo, criamos uma coleção de inteiros chamada `numeros`. Adicionamos alguns números à coleção, verificamos se um número está na coleção, removemos um número, obtemos a contagem de números na coleção e limpamos a coleção. Isso demonstra como a interface `ICollection` pode ser usada para trabalhar com uma coleção de itens em C#.

## IList 

**IList** é uma interface em C# que representa uma coleção de objetos que podem ser acessados individualmente por índice. Ela herda da interface `ICollection` e adiciona métodos para adicionar, remover e inserir elementos, além de propriedades para acessar elementos por índice.

### Uso

A interface `IList` é implementada por classes de coleção no .NET Framework, como `ArrayList` e `List<T>`. Ela fornece uma maneira flexível de trabalhar com coleções que precisam permitir a adição, remoção e inserção de elementos.

### Exemplo

Aqui está um exemplo simples de como a interface `IList` é usada em C#:

```csharp
// Criação de uma lista de inteiros
IList<int> numeros = new List<int>();

// Adicionando itens à lista
numeros.Add(1);
numeros.Add(2);
numeros.Add(3);

// Acessando itens da lista
Console.WriteLine(numeros[0]);  // Saída: "1"

// Removendo um item da lista
numeros.Remove(2);

// Inserindo um item na lista
numeros.Insert(1, 4);

// Iterando sobre a lista
foreach (int numero in numeros)
{
    Console.WriteLine(numero);  // Saída: "1", "4", "3"
}
```

Neste exemplo, criamos uma lista de inteiros chamada `numeros`. Adicionamos alguns números à lista, acessamos um número pelo índice, removemos um número, inserimos um novo número e iteramos sobre a lista para imprimir todos os números. Isso demonstra como a interface `IList` pode ser usada para trabalhar com uma coleção de itens em C#.

## Uso de Where, First e Find em Listas em C#

`Where`, `First` e `Find` são métodos úteis em C# para trabalhar com coleções, especificamente com o tipo `List<T>`. Eles são usados para consultar e filtrar dados em uma coleção.

- **Where**: Este método é usado para filtrar uma coleção com base em uma condição específica. Ele retorna uma nova coleção que inclui apenas os elementos que satisfazem a condição.

- **First**: Este método é usado para recuperar o primeiro elemento de uma coleção que satisfaz uma condição específica.

- **Find**: Este método é usado para buscar o primeiro elemento de uma `List<T>` que corresponde à condição especificada.

### Uso

Esses métodos são geralmente usados com expressões lambda para definir a condição de filtragem ou correspondência.

### Exemplo

Aqui está um exemplo simples de como `Where`, `First` e `Find` são usados em C#:

```csharp
// Criação de uma lista de inteiros
List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

// Uso do método Where
var numerosPares = numeros.Where(n => n % 2 == 0);
Console.WriteLine(string.Join(", ", numerosPares));  // Saída: "2, 4"

// Uso do método First
var primeiroPar = numeros.First(n => n % 2 == 0);
Console.WriteLine(primeiroPar);  // Saída: "2"

// Uso do método Find
var primeiroImpar = numeros.Find(n => n % 2 != 0);
Console.WriteLine(primeiroImpar);  // Saída: "1"
```

Neste exemplo, criamos uma lista de inteiros chamada `numeros`. Usamos o método `Where` para filtrar os números pares, o método `First` para encontrar o primeiro número par e o método `Find` para encontrar o primeiro número ímpar. Isso demonstra como `Where`, `First` e `Find` podem ser usados para consultar e filtrar dados em uma lista em C#.

