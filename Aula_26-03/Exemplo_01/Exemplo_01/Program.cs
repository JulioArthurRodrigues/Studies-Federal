namespace Exemplo_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis inteiras
            int num1, num2, soma, sub, mult, div;
         
            //Exibir mensagens e ler os números de entrada
            Console.Write("Digite o Primeiro Número:");
            num1 = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o Segundo Número:");
            num2 = int.Parse(Console.ReadLine());

            //Limpeza de tela
            Console.Clear();
            Console.WriteLine("------RESULTADOS--------");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            //Faça os cálculos e atribua o valor para as variáveis
            soma = num1 + num2;
            sub = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;

            //Exibir saídas
            Console.WriteLine("Soma: {0}", soma);
            Console.WriteLine("Subtração: {0}", sub);
            Console.WriteLine("Multiplicação: {0}", mult);
            Console.WriteLine("Divisão: {0}", div);

            //Outro tipo de saída 
            Console.WriteLine("A soma de {0} com {1} = {2}", num1, num2, soma);
            
            //Pausa para o encerramento do programa
            Console.ReadKey();

        }
    }
}
