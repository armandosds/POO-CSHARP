namespace _13Abstracao;

public class PessoaJuridica : Padrao
{
    //Método obrigatório
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de empréstimo para pessoa jurídica R$: " + (valor * 0.2));
    }
}