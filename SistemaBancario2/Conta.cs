using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario2
{
    internal class Conta
    {
        static int proximoId = 1;
        public Pessoa Titular { get; set; }
        public int Id { get; set; }
        private decimal Saldo { get; set; }

        public Conta() { }
        public Conta( Pessoa titular, decimal saldo = 0)
        { 
            Titular = titular;
            Saldo = saldo;
            Id = proximoId++;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.Clear();
                Console.WriteLine("Valor inválido para depósito");
                return;
            }
                
            Saldo += valor;
            Console.WriteLine($"Valor {valor:F2} Depositado com sucesso!");
            Console.Clear();

        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0 || valor > Saldo)
            {
                Console.Clear();
                Console.WriteLine("Impossivel sacar o valor requerido");
                return;
            }

            Saldo -= valor;
            Console.WriteLine($"Valor {valor:F2} sacado com sucesso!");
        }
            
        public void ExibirSaldo()
        {
            Console.Clear();
            Console.WriteLine($"Seu saldo é de R${Saldo:F2}");
            return;
        }
    }
}
