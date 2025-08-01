# O tipo DateTime

Lembrete pra mim: sempre que preciso de data ou hora, uso `DateTime`. Pra pegar a data/hora atual, é só usar `DateTime.Now`. Se quiser criar uma data específica, passo ano, mês e dia.

Exemplo:
```csharp
DateTime agora = DateTime.Now;
DateTime nascimento = new DateTime(2000, 5, 10);
Console.WriteLine(agora);
```

Consigo comparar datas, somar dias, formatar do jeito que quiser... sempre uso quando preciso lidar com tempo no sistema.
