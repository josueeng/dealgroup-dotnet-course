# Convenções de escrita de classe

Lembrete pra mim: sempre uso PascalCase pra nome de classe, tipo `PessoaFisica`. Tento dar nomes que realmente dizem o que a classe faz ou representa. Se a classe começar a ficar muito grande, já penso em dividir.

Gosto de deixar cada classe em um arquivo separado, fica mais fácil de achar depois.

Exemplo:
```csharp
public class PessoaFisica
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}
```

Se eu seguir isso, meu código fica mais limpo e não me atrapalho quando for procurar algo.
