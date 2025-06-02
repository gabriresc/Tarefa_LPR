int[] numros = new int[10];
void main()
{
    int digitado = 0;
    bool continuar = true;
    for (int i = 0; i < numros.Length; i++)
    {
        Console.WriteLine("Digite o numero " + (i + 1) + ":");
        numros[i] = Convert.ToInt32(Console.ReadLine());
    }
    while (continuar == true)
    {
        Console.WriteLine("Digite o numero a ser procurado:");
        digitado = Convert.ToInt32(Console.ReadLine());
        posicao(digitado);
        Console.WriteLine("Quer continuar?-> 1-sim|2-não");
        digitado = Convert.ToInt32(Console.ReadLine());
        if (digitado == 0)
        {
            continuar = false;
        }
    }
}
void posicao( int recebido)
{
    int total = 0;
    for (int i = 0; i < numros.Length; i++)
    {
        if (recebido == numros[i])
        {
            Console.WriteLine($"Posição:{i + 1}");
            total++;
        }
    }
    if (total == 0)
    {
        Console.WriteLine($"O numero não existe");
    }
    else
    {
        Console.WriteLine($"Total de aparições:{total}");
    }
}
main();


