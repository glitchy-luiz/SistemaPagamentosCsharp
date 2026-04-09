
using SistemaPagamentos.Service;
using SistemaPagamentos.Util;

var pagamentoService = new PagamentoService();
bool executar = true;

while (executar)
{
    int opcao = Menu.ExibirMenu();

    switch (opcao)
    {
        case 1:
            pagamentoService.ProcessarPagamentoCartao();
            break;

        case 2:
            pagamentoService.ProcessarPagamentoBoleto();
            break;

        case 3:
            executar = false;
            Console.WriteLine();
            Console.WriteLine("Encerrando o sistema...");
            break;
    }
}
