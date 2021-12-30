namespace _04ExercicioIMC;

public class Pessoa
{
    public double peso, altura;
    
    public double calculo()
    {
        return peso / (altura * altura);
    }
    
    public void condicoes(double calculo)
    {
        if (calculo < 18.5)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (calculo >= 18.5 && calculo <= 24.9)
        {
            Console.WriteLine("Peso normal");
        }
        else if (calculo >= 25 && calculo <= 29.9)
        {
            Console.WriteLine("Sobrepeso");
        }
        else if (calculo >= 30 && calculo <= 34.9)
        {
            Console.WriteLine("Obesidade grau 1");
        }
        else if (calculo >= 35 && calculo <= 39.9)
        {
            Console.WriteLine("Obesidade grau 2");
        }
        else if (calculo >= 40)
        {
            Console.WriteLine("Obesidade grau 3");
        }
    }

    public void mensagem()
    {
        double imcTotal = calculo();
        condicoes(imcTotal);
        Console.WriteLine("Índice de massa corporal: "+ imcTotal.ToString("F"));
    }

}