

namespace SistemaPagamentos.Util
{
    public static class Menu
    {
        public static int ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("***** Sistema de Processamento de Pagamentos *****");
            Console.WriteLine();
            Console.WriteLine("********** Escolha a forma de pagamento **********");
            Console.WriteLine();
            Console.WriteLine("1 - Cartão");
            Console.WriteLine("2 - Boleto");
            Console.WriteLine("3 - Sair");
            Console.WriteLine();
            Console.Write("Escolha uma opção: ");

            while (true)
            {
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int opcao) && opcao >= 1 && opcao <= 3)
                {
                    return opcao;
                }

                Console.Write("Opção inválida. Digite 1, 2 ou 3: ");
            }
        }

    }
}
