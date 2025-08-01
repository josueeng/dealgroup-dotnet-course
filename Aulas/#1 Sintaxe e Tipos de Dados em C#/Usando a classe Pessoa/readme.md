# Usando a classe Pessoa

Pra não esquecer: quando quero testar orientação a objetos, sempre crio uma classe `Pessoa` pra brincar. Fica assim:

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "João";
pessoa1.Idade = 28;
```

Com isso, já dá pra criar vários objetos e testar métodos, propriedades, etc. Sempre uso esse exemplo pra fixar o conceito.
