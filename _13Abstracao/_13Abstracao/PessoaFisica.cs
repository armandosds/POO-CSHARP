namespace _13Abstracao;

public class PessoaFisica : Padrao
{
    //Método obrigatório
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de empréstimo para pessoa física R$: " + (valor * 0.1));
    }
}