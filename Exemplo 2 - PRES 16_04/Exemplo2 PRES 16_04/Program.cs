namespace Exemplo2_PRES_16_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            Console.WriteLine("Opções do Sistema");
            Console.WriteLine("-----------------");
            Console.WriteLine("1. Cadastro");
            Console.WriteLine("2. Alteração");
            Console.WriteLine("3. Exclusão");
            Console.WriteLine("4. Sair do Sistema");
            Console.WriteLine("-----------------");
            Console.WriteLine("Sua opção? : ");
            opcao = Console.ReadLine();

            opcao = opcao.ToUpper();

            switch(opcao)
            {
                case "1":
                case "C":
                    Console.WriteLine("Você Escolheu Cadastro");
                    break;
                
                case "2":
                case "A":
                    Console.WriteLine("Você Escolheu Alteração");
                    break;
                
                case "3":
                case "E":
                    Console.WriteLine("Você Escolheu Exclusão");
                    break;
                
                case "4":
                case "F":
                    Console.WriteLine("Você Escolheu Finalizar");
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }
    }
}
