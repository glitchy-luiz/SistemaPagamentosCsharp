
using System.Globalization;

namespace SistemaPagamentos.Model
{
    public class PagamentoBoleto : PagamentoBase
    {
        public string CodigoBarras { get; private set; }

        public PagamentoBoleto(decimal valor, string codigoBarras): base(valor)
        {
            CodigoBarras = codigoBarras;
        }

        public override string ProcessarPagamento()
        {
            return $"Processando pagamento de {Valor.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))} " +
                   $"via Boleto (Cod Barra: {CodigoBarras}) na data {DataPagamento:dd/MM/yyyy}.";
        }

    }
}
