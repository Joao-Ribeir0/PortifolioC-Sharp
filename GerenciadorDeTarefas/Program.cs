using System;
using GerenciadorDeTarefas;

class Program
{
    static Gerenciador gerenciador = new Gerenciador();
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Bem vindo ao seu sistema Gerenciador de Tarefas!\n");
            Console.WriteLine("O que você deseja fazer? \n" +
                "[1] - Adicionar Tarefa\n" +
                "[2] - Remover Tarefa\n" +
                "[3] - Editar Tarefa\n" +
                "[4] - Listar Tarefas\n" +
                "[5] - Marcar Tarefa Como Concluída\n" +
                "[6] - Salvar\n" +
                "[7] - Sair\n");

            int opcaoEscolhida;

            if (int.TryParse(Console.ReadLine(), out opcaoEscolhida))
            {
                switch (opcaoEscolhida)
                {
                    case 1:
                        gerenciador.AdicionarTarefa();
                        break;

                    case 2:
                        gerenciador.RemoverTarefa();
                        break;

                    case 3:
                        gerenciador.EditarTarefa();
                        break;

                    case 4:
                        gerenciador.ListarTarefas();
                        break;

                    case 5:
                        gerenciador.MarcarComoConcluida();
                        break;

                    case 6:
                        gerenciador.SalvarTarefas();
                        break;

                    case 7:
                        gerenciador.Sair();
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida!\n");
                        break;
                }
            }
        }
    }
}