namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo t1 = new Retangulo();
            Console.WriteLine("Digite a altura :");
            t1.Altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a largura :");
            t1.Largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("area:"+ t1.Area());
            Console.WriteLine("perimetro:" + t1.Perimetro());
        }
    }
}
