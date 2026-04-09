
using SistemaPagamentos.Interface;

namespace SistemaPagamentos.Model
{
    public abstract class PagamentoBase : IProcessavel
    {
        public decimal Valor { get; protected set; }
        public DateTime DataPagamento { get; protected set; }

        protected PagamentoBase(decimal valor)
        {
            Valor = valor;
            DataPagamento = DateTime.Now;
        }

        public abstract string ProcessarPagamento();
    }
}
