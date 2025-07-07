using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
        numeros.Add(4);
        numeros.Insert(3, 8);
        bool contem4 = numeros.Contains(8);
        if (contem4) Console.WriteLine("A lista contem 8");
        int maior4 = 0;
        int numero3 = 0;
        foreach (int i in numeros)
        {
            if (i > 4)
            {
                maior4++;
            }
            if (i == 3)
            {
                numero3++;
            }
        }
        Console.WriteLine($"Contem {maior4} maiores que 4\nContem {numero3} numeoros 3");
        numeros.Remove(2);
        while (numeros.Contains(4)) numeros.Remove(4);
        foreach (int x in numeros)
        {
            Console.WriteLine(x);
        }
    }



}