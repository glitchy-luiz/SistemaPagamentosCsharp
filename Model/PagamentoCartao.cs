
using System.Globalization;

namespace SistemaPagamentos.Model
{
    public class PagamentoCartao : PagamentoBase
    {
        public string NumeroCartao { get; private set; }

        public PagamentoCartao(decimal valor, string numeroCartao) : base(valor)
        {
            NumeroCartao = numeroCartao;
        }

        public override string ProcessarPagamento()
        {
            return $"Processando pagamento de {Valor.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))} " +
                   $"via Cartão (Número: {NumeroCartao}) na data {DataPagamento:dd/MM/yyyy}.";
        }

    }
}
