# NPF - Processo de seleção ## Respostas

## Respostas

\*\* Exercicio 1

- Resposta:
  b) O valor armazenado em N elevado ao quadrado.

* Resolução:

## Usage

```c#
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste NPF");
            Console.WriteLine(Recursividade(4));
            Console.ReadKey();
        }

        private static int Recursividade(int numero)
        {
            if (numero == 0) return 0;
            return (numero \* 2 - 1) + Recursividade(numero - 1);
        }
    }
}
  // numero = 4 resultado = 16
  // numero = 5 resultado = 25
```

\*\* Exercicio 2

- Resposta:
  a) Apenas as queries C2 e C3 são equivalentes.
