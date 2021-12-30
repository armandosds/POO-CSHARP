namespace _02Metodos;

class Pessoa
{
    //Método 01
    public void apresentar()
    {
        Console.WriteLine("Olá, sou o Método 01");
    }
    //Método 02
    public void apresentar(string nome)
    {
        Console.WriteLine("Olá, sou o Método 02 e meu nome é " + nome);
    }
    //Método 03
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine("Olá, sou o Método 03 e meu nome é " + nome + " e tenho " + idade + " anos");
    }
}