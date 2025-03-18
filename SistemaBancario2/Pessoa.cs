using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario2
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }

        public Pessoa() { }
        public Pessoa(string nome, int idade, string cpf, string senha)
        {
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
            Senha = senha;
        }
    }
}
