namespace exemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            triangulo triangulo = new triangulo();
            triangulo.ladoA = 3;
            triangulo.ladoB = 4;
            triangulo.ladoC = 5;
            double area = triangulo.calculararea();
            Console.WriteLine("A area do triangulo é: " + area);
        }
    }
}
