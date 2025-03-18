using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas
{
    internal class Tarefa
    {
        public string Nome  { get; set; } //get permite que o valor da propriedade seja lido de fora da classe e set permite que o valor seja atribuído de fora da classe
        public bool Concluida { get; set; }
        public string Descricao { get; set; }
        public int Id { get; set; }

        public Tarefa(string nome, int id, string descricao = "Tarefa sem descrição")
        {
            Nome = nome;
            Descricao = descricao;
            Id = id;
            Concluida = false;
        }

        public void Concluir()
        {
            Concluida = true;
            Console.WriteLine($"Tarefa concluída!");
        }
    }


}
