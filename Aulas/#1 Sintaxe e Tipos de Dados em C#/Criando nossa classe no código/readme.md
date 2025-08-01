# Criando nossa classe no código

Quando quero criar uma classe do zero, sempre começo assim:

```csharp
public class Carro
{
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public void Ligar() {
        Console.WriteLine("Carro ligado!");
    }
}
```

Depois é só criar objetos dessa classe e sair testando. Gosto de fazer isso pra entender bem como funciona cada parte.
