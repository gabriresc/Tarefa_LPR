void main()
{
    int[,] matrizA = new int[3, 3];
    int[,] matrizB = new int[3, 3];
    int[,] matrizfinal = new int[3, 3];
    Console.WriteLine("Para a matriz A");
    for (int i = 0; i < matrizA.GetLength(0); i++)
    {
        for (int j = 0; j < matrizA.GetLength(1); j++)
        {
            Console.WriteLine("Digite o valor que quer atribuir na linha " + (i + 1) + " e coluna" + (j + 1));
            matrizA[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    Console.WriteLine("Para a matriz B");
    for (int i = 0; i < matrizB.GetLength(0); i++)
    {
        for (int j = 0; j < matrizB.GetLength(1); j++)
        {
            Console.WriteLine("Digite o valor que quer atribuir na linha " + (i + 1) + " e coluna" + (j + 1));
            matrizB[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    
    
    

}