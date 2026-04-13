# Sistema de Processamento de Pagamentos (Console App)
## Descrição
Este projeto é uma aplicação Console em C# desenvolvida com o objetivo de praticar Programação Orientada a Objetos (POO) e boas práticas de arquitetura, simulando um sistema simples de processamento de pagamentos.
O sistema permite ao usuário escolher entre pagamento com Cartão ou pagamento com Boleto, coletar os dados necessários, processar a operação e exibir um resumo da transação.

## Autores:
(completar nome e rm dps)
- Bruno Otavio RM:
- Guilherme Flores RM:
- Leonardo RM:
- Luiz Fernando de Aragão Souza RM:
- Marcello de Freitas Moreira RM:

## Objetivos do Projeto

Praticar conceitos fundamentais de POO
Aplicar separação de responsabilidades
Organizar o código em camadas bem definidas
Trabalhar com tipagem correta para valores monetários
Desenvolver um fluxo completo em Console Application


## Estrutura do Projeto
```
PagamentoConsoleApp
│
├─ Program.cs
│
├─ Interface/
│  └─ IProcessavel.cs
│
├─ Model/
│  ├─ PagamentoBase.cs
│  ├─ PagamentoCartao.cs
│  └─ PagamentoBoleto.cs
│
├─ Service/
│  └─ PagamentoService.cs
│
└─ Util/
   ├─ Menu.cs
   └─ ConversorValor.cs
```

## Fluxo de Funcionamento

1. O sistema exibe um menu principal

<img width="439" height="162" alt="image" src="https://github.com/user-attachments/assets/e7d7c0b9-153d-4b90-a39e-570cfb242533" />

2. O usuário escolhe a forma de pagamento:
- Cartão

<img width="722" height="137" alt="image" src="https://github.com/user-attachments/assets/211f8e4f-ae7e-47d6-bca6-ad232f5525f7" />

- Boleto

<img width="810" height="136" alt="image" src="https://github.com/user-attachments/assets/1030e62d-4d57-46ad-9cff-0fc61c770ecc" />

3. O sistema solicita:
- Valor do pagamento (aceita , ou .)
- Dados específicos (cartão ou boleto)
4. O pagamento é processado
5. Um resumo é exibido no console
6. O menu é exibido novamente até o usuário escolher sair
