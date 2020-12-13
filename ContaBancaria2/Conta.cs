using System;

namespace ContaBancaria2
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public double LimiteDeSaque { get; set; }

        public Conta(){}

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteDeSaque = 1200;
        }

        public string DadosConta()
        {
            Console.WriteLine($"Dados da conta atualizado:");
            return $"Conta: {Numero}; Titular da conta: {Titular}; Saldo atual: R${Saldo}.";
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }

    }
}
