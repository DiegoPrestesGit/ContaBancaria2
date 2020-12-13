using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaBancaria2
{
    class SistemaBancario
    {
        public Conta CriarConta()
        {
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Entre com o saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta: {numero}; Titular da conta: {titular}; Saldo atual: R${saldo}.");
            Console.WriteLine("Pressione enter para continuar");
            Console.ReadLine();
            return new Conta(numero, titular, saldo);
        }

        public void MenuPrincipal()
        {
            Console.WriteLine("BEM VINDO AO BANCO DA UNATCO");
            Console.WriteLine("antes de utilizar nossos serviços é necessário criar uma conta");
            Console.WriteLine();
            Conta conta = CriarConta();

            Boolean flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("DIGITE A OPERAÇÃO QUE DESEJA FAZER:");
                Console.WriteLine("SAQUE                            [1]");
                Console.WriteLine("DEPÓSITO                         [2]");
                Console.WriteLine("VER DADOS BANCÁRIOS              [3]");
                Console.WriteLine("SAIR DO SISTEMA BANCÁRIO         [0]");

                int operacao = int.Parse(Console.ReadLine());
                switch (operacao)
                {
                    case 1:
                        Console.Clear();
                        Saque(conta);
                        Console.WriteLine(conta.DadosConta());
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        Deposito(conta);
                        Console.WriteLine(conta.DadosConta());
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine(conta.DadosConta());
                        Console.ReadLine();
                        break;

                    case 0:
                        flag = false;
                        Console.WriteLine("OBRIGADO PELA PREFERÊNCIA E VOLTE SEMPRE!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }

        private void Deposito(Conta conta)
        {
            Console.WriteLine("BEM VINDO AO MENU DE DEPÓSITO!");
            Console.WriteLine("Qual valor gostaria de depositar?");
            double valor = double.Parse(Console.ReadLine());

            conta.Deposito(valor);
        }

        private void Saque(Conta conta)
        {
            Console.WriteLine("BEM VINDO AO MENU DE SAQUE!");
            Console.WriteLine($"Qual valor gostaria de sacar (limite da conta: R${conta.LimiteDeSaque})?");
            double valor = double.Parse(Console.ReadLine());

            if (valor > conta.LimiteDeSaque || valor > conta.Saldo)
            {
                Console.WriteLine("Valor de saque não permitido!");
                Console.WriteLine("pressione enter para continuar...");
                Console.ReadLine();
                return;
            }
            conta.Saque(valor);
        }
    }
}
