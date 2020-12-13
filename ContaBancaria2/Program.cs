using System;

namespace ContaBancaria2
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute();
            Console.Read();
        }
        public static void Execute()
        {
            SistemaBancario sistema = new SistemaBancario();
            sistema.MenuPrincipal();
        }
    }
}
