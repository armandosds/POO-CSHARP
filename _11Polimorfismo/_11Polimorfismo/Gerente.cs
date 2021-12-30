namespace _11Polimorfismo;

public class Gerente : Imposto
{
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("O gerente recebeu um desconto do vale alimentacao de R$" + (salario * 0.15));
    }
}