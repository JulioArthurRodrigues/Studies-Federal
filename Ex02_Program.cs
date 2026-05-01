using System.Security.Authentication;

namespace Ex02_Tabuada5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string continua = "S";

            while (continua == "S")
            { 
                Console.Clear();
                //validação do número de entrada
                do
                {
                    Console.WriteLine("Informe um número de 1 a 10");
                    numero = int.Parse(Console.ReadLine());
                } while (numero < 1 || numero > 10);

                //limpa a tela
                Console.Clear();
                Console.WriteLine("Tabuada do número: {0}", numero);
                Console.WriteLine("----------------------");

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} * {1} = {2}", numero, i, numero * i);
                }
                Console.WriteLine("Deseja visualizar a tabuada de outro número? [S/N]");
                continua = Console.ReadLine().ToUpper();
           }
        }
    }
}
