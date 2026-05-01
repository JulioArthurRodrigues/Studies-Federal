namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 1; i <=50; i++)
            {
                Console.WriteLine(i);
                soma = soma + i;
                Console.WriteLine("A soma dos números é: {0}", soma);
            }
            Console.WriteLine("A soma dos números é: {0}", soma);
            Console.ReadKey();
        }
    }
}
