namespace _13Abstracao;

public abstract class Padrao
{
    //Método obrigatório
    public abstract void taxaEmprestimo(double valor);

    //Método Opcional
    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupanca: " + (valor * taxa));
    }
}