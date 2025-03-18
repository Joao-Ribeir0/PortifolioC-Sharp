using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Estoque
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public string Cargo { get; set; }

        public Funcionario(string nome, int idade, string senha, string cpf, string cargo)
        {
            Nome = nome;
            Idade = idade;
            Senha = senha;
            Cpf = cpf;
            Cargo = cargo;
        }
    }
}
