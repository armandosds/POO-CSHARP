namespace _11Polimorfismo;

public class Atendente : Imposto
{
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("O atendente recebeu um desconto do vale alimentacao de R$" + (salario * 0.12));
    }
}