namespace _06Encapsulamento;

public class Aluno
{
    private double nota1, nota2;

    private double media()
    {
        return (nota1 + nota2) / 2;
    }

    public void mensagem()
    {
        Console.WriteLine("Digite a primeira nota: ");
        nota1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Digite a segunda nota: ");
        nota2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("A média do aluno é: " + media());
    }
}