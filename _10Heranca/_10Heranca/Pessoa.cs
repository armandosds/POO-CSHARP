﻿namespace _10Heranca;

public class Pessoa
{
    protected string nome;
    protected int idade;

    protected void mensagemPessoa()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
    }
}