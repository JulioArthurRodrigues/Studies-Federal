namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, positivos = 0, negativos = 0;

            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Informe o {0}º número", i);
                numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    negativos++;
                }
                else
                {
                    positivos++;
                }
            }
            Console.WriteLine("Positivos: {0}", positivos);
            Console.WriteLine("Negativos: {0}", negativos);
        }
    }
}
