void main()
{
    int[,] matrizA = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    int[,] matrizB = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
    int[,] matrizfinal = new int[3, 3];
    
    for (int row = 0; row < 3; row++) {
        for (int col = 0; col < 3; col++) {
            
            for (int inner = 0; inner < 3; inner++) {
                matrizfinal[row, col] += matrizA[row, inner] * matrizB[inner, col];
            }
            Console.Write(matrizfinal[row, col] + "  ");
        }
        Console.WriteLine();
    }

}