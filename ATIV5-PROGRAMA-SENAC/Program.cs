using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a sua idade:");
        int idade = int.Parse(Console.ReadLine());

        if (idade < 18)
        {
            Console.WriteLine("Você é menor de idade, não pode dirigir");
        }
        else if (idade >= 18 && idade < 60)
        {
            Console.WriteLine("Você é um adulto.");
        }
        else
        {
            Console.WriteLine("Você é um idoso.");
        }
    }
}
