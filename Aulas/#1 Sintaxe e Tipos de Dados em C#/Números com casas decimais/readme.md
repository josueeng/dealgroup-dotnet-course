# Números com casas decimais

Quando preciso de número com vírgula, quase sempre uso `double`. Se for dinheiro, uso `decimal` pra não dar erro de arredondamento. `float` só uso se precisar economizar memória (o que é raro).

Exemplo:
```csharp
double preco = 19.99;
float temperatura = 23.5f;
decimal saldo = 1000.75m;
```
Sempre olho o tipo pra não ter surpresa depois.
