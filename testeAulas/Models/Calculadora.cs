namespace testeAulas.Models;


public class Calculadora
{
    public void somar(int a, int b)
    {
        Console.WriteLine($"A soma de {a} e {b} é {a + b}");
    }

    public void subtrair(int a, int b)
    {
        Console.WriteLine($"A subtração de {a} e {b} é {a - b}");
    }
    public void multiplicar(int a, int b)
    {
        Console.WriteLine($"A multiplicação de {a} e {b} é {a * b}");
    }
    public void dividir(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Divisão por zero não é permitida.");
            return;
        }
        Console.WriteLine($"A divisão de {a} e {b} é {a / b}");
    }
}
