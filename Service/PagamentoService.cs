

using SistemaPagamentos.Model;
using SistemaPagamentos.Util;

namespace SistemaPagamentos.Service
{
    public class PagamentoService
    {
        public void ProcessarPagamentoCartao()
        {
            decimal valor = ConversorValor.LerValorMonetario();

            Console.Write("Informe o número do cartão: ");
            string numeroCartao = Console.ReadLine();

            var pagamento = new PagamentoCartao(valor, numeroCartao);

            Console.WriteLine();
            Console.WriteLine(pagamento.ProcessarPagamento());
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public void ProcessarPagamentoBoleto()
        {
            decimal valor = ConversorValor.LerValorMonetario();

            Console.Write("Informe o código de barras: ");
            string codigoBarras = Console.ReadLine();

            var pagamento = new PagamentoBoleto(valor, codigoBarras);

            Console.WriteLine();
            Console.WriteLine(pagamento.ProcessarPagamento());
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

    }
}
