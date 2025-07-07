using System.Collections.Generic;

class exerc1
{
    static void Main()
    {
        List<string> nomes = new List<string> { };
        int quantNomes = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < quantNomes; i++)
        {
            string nome = Console.ReadLine();
            nomes.Add(nome);
        }


        while (nomes.Count != 0)
        {
            List<string> nomesTemp = new List<string> { };
            int contMaior = 0;
            int contMenor = 1000;

            foreach (string x in nomes)
            {
                if (x.Length > contMaior)
                {
                    contMaior = x.Length;
                }
                if (x.Length < contMenor)
                {
                    contMenor = x.Length;
                }
            }
            for (int i = contMenor; i <= contMaior; i++)
            {
                foreach (string x in nomes)
                {
                    if (i == x.Length)
                    {
                        nomesTemp.Add(x);
                        nomes.Remove(x);
                        break;
                    }
                }
            }
            foreach (string x in nomesTemp)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }
    }
}