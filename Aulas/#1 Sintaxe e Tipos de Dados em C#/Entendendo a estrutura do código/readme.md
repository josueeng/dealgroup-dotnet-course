# Entendendo a estrutura do código

Lembrete pra mim: todo arquivo C# segue um padrão. Sempre começo com os `using` lá em cima, depois o namespace, depois as classes e métodos.

Exemplo:
```csharp
using System;

namespace MeuProjeto
{
    public class Programa
    {
        public static void Main()
        {
            Console.WriteLine("Olá, mundo!");
        }
    }
}
```

Se eu seguir esse padrão, nunca me perco na hora de criar ou entender um arquivo novo.
