# Array

Arrays em C# são uma estrutura de dados que armazena uma coleção de elementos. Esses elementos são acessíveis por meio de um índice, que é um número inteiro. Aqui está um exemplo de como você pode usar arrays em C#:

```csharp
// Declare e inicialize um array
int[] numeros = new int[5] {1, 2, 3, 4, 5};
//ou
var numeros2 = new int[5] {6, 7, 8, 9, 10};

// Acesse um elemento do array
int primeiroNumero = numeros[0];
Console.WriteLine("O primeiro número é: " + primeiroNumero);

// Altere um elemento do array
numeros[0] = 10;
Console.WriteLine("O novo primeiro número é: " + numeros[0]);

// Percorra todos os elementos do array
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Número na posição " + i + " é: " + numeros[i]);
}
```

Neste exemplo, um novo array de inteiros é criado e inicializado com os valores 1, 2, 3, 4 e 5. O primeiro elemento do array é acessado usando o índice 0 (os arrays em C# são indexados a partir de 0). O primeiro elemento do array é então alterado para 10. Finalmente, todos os elementos do array são percorridos e impressos usando um loop `for`.


## Pecorrendo um array

Percorrer um array em C# é uma tarefa comum quando se trabalha com coleções de dados. Existem várias maneiras de fazer isso, incluindo o uso de loops `for`, `foreach` e métodos de extensão como `Array.ForEach`. Aqui estão alguns exemplos:

## Usando `for`

```csharp
int[] numeros = {1, 2, 3, 4, 5};

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Número na posição " + i + " é: " + numeros[i]);
}
```

Neste exemplo, um loop `for` é usado para percorrer o array. A propriedade `Length` do array é usada para determinar quantas vezes o loop deve ser executado.

## Usando `foreach`

```csharp
int[] numeros = {1, 2, 3, 4, 5};

foreach (int numero in numeros)
{
    Console.WriteLine("O número é: " + numero);
}
```

Neste exemplo, um loop `foreach` é usado para percorrer o array. O loop `foreach` é mais simples e mais fácil de ler do que o loop `for`, mas não fornece acesso ao índice do elemento atual.

## Usando `Array.ForEach`

```csharp
int[] numeros = {1, 2, 3, 4, 5};

Array.ForEach(numeros, numero => {
    Console.WriteLine("O número é: " + numero);
});
```

Neste exemplo, o método de extensão `Array.ForEach` é usado para percorrer o array. Este método aceita dois argumentos: o array a ser percorrido e uma função a ser executada para cada elemento do array. A função é fornecida como uma expressão lambda.
