# O conceito de classe

Pra mim, classe é tipo um molde: defino como vai ser o "objeto" e depois posso criar quantos quiser daquele tipo. Sempre penso nela como um jeito de organizar dados e funções que têm a ver entre si.

Exemplo:
```csharp
public class Pessoa
{
    public string Nome;
    public void Falar() {
        Console.WriteLine("Olá!");
    }
}
```

Com isso, posso criar vários objetos diferentes, cada um com seus próprios valores. Ajuda muito a deixar o código mais organizado.
