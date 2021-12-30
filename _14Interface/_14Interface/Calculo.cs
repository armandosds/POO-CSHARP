namespace _14Interface;

public class Calculo : IPadrao
{
    public void somar(int n1, int n2)
    {
        Console.WriteLine("Soma: " + (n1 + n2));
    }

    public void subtrair(int n1, int n2)
    {
        Console.WriteLine("Subtração: " + (n1 - n2));
    }
}