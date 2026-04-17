namespace Exercício_1___Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, sum, sub, div, mult, pow;
            Console.WriteLine("Digite dois números reais");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            string calculadora;
            Console.WriteLine("Calculadora");
            Console.WriteLine("--------------");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Divisão");
            Console.WriteLine("4. Multiplicação");
            Console.WriteLine("5. Potenciação");
            Console.WriteLine("---------------");
            Console.WriteLine("Digite os dois números reais: ");
            calculadora = Console.ReadLine();

            switch(calculadora)
            {
                case "1":
                case "Soma":
                    Console.WriteLine("1. Some os dois números");
                    Console.WriteLine("A soma entre os dois números reais é: {0}", sum = a + b);
                    break;

                case "2":
                case "Subtração":
                    Console.WriteLine("2. Subtraia os dois números");
                    Console.WriteLine("A subtração entre os dois números reais é: {0}", sub = a - b);
                    break;

                case "3":
                case "Divisão":
                    Console.WriteLine("3. Divida os dois números");
                    Console.WriteLine("A divisão entre os dois números reais é: {0}", div = a / b);
                    break;

                case "4":
                case "Multiplicação":
                    Console.WriteLine("4. Multiplique os dois números");
                    Console.WriteLine("A multiplicação entre os dois números reais é: {0}", mult = a * b);
                    break;

                case "5":
                case "Potenciação":
                    Console.WriteLine("5. Faça a potenciação entre os dois números");
                    Console.WriteLine("A potenciação entre os dois números reais é: {0}", Math.Pow(a,b));
                    break;

                 Console.WriteLine("\nPressione qualquer tecla para sair...");
                 Console.ReadKey();
            }
        }
    }
}
