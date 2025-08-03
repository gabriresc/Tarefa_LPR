using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> pessoa = new();
        Console.WriteLine("Quantas pessoas?");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine("Digite o nome da pessoa " + (i + 1));
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o idade da pessoa " + (i + 1));
            int idade = Convert.ToInt32(Console.ReadLine());
            pessoa.Add(nome, idade);
        }
        int soma = 0;
        int idmenor = 1000000;
        int idmaior = 0;
        string nomenor = "";
        string nomaior = "";
        foreach (var idade in pessoa)
        {
            soma += idade.Value;
            if (idade.Value < idmenor)
            {
                idmenor = idade.Value;
                nomenor = idade.Key;
            }
            if (idade.Value > idmaior)
            {
                idmaior = idade.Value;
                nomaior = idade.Key;
            }
        }
        Console.WriteLine($"Maior idade:Nome:{nomaior},idade:{idmaior}");
        Console.WriteLine($"Menor idade:Nome:{nomenor},idade:{idmenor}");
        float media = soma / x;
        foreach (var maior in pessoa)
        {
            if (maior.Value > media)
            {
                Console.WriteLine($"Acima da media:Nome:{maior.Key},idade:{maior.Value}");
            }
        }
        Console.WriteLine("Digite qual idade remover?");
        int remover = Convert.ToInt32(Console.ReadLine());
        foreach (var rem in pessoa)
        {
            if (rem.Value == remover) pessoa.Remove(rem.Key);
        }
        foreach (var d in pessoa)
        {
            Console.WriteLine($"Nome: {d.Key}, idade: {d.Value}");
        }
    }




}