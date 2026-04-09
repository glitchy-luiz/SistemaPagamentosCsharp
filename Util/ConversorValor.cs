

using System.Globalization;

namespace SistemaPagamentos.Util
{
    public static class ConversorValor
    {
        public static decimal LerValorMonetario()
        {
            Console.Write("Informe o valor do pagamento: ");

            while (true)
            {
                string input = Console.ReadLine();

                if (decimal.TryParse(
                        input,
                        NumberStyles.Number,
                        CultureInfo.GetCultureInfo("pt-BR"),
                        out decimal valor))
                {
                    return valor;
                }

                if (decimal.TryParse(
                        input,
                        NumberStyles.Number,
                        CultureInfo.InvariantCulture,
                        out valor))
                {
                    return valor;
                }

                Console.Write("Valor inválido. Tente novamente: ");
            }
        }

    }
}
