using System.Text.Json;
using System.IO;

namespace GerenciadorDeTarefas
{
    internal class Gerenciador
    {
        List<Tarefa> tarefas = new List<Tarefa>(); 
        public int idTarefa = 0;

        internal void AdicionarTarefa()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Qual tarefa deseja adicionar?\n ");
                string nome = Console.ReadLine();

                Console.WriteLine("\nAdicione uma descrição para sua tarefa...\n ");
                string descricao = Console.ReadLine();

                int novoId = idTarefa  + 1;

                Tarefa novatarefa = new Tarefa(nome, novoId, descricao);

                idTarefa = novoId;

                tarefas.Add(novatarefa);

                SalvarTarefas();

                Console.WriteLine($"\nTarefa adicionada com sucesso!\n");

                Console.WriteLine("\nDeseja Adicionar uma nova tarefa? \n[S]im  \n[N]ão\n");
                string escolha = Console.ReadLine().ToLower();

                if (escolha.StartsWith("s")) continue;
                else break;

            }

            Console.WriteLine("\nPressione qualquer tecla para prosseguir...\n");
            Console.ReadKey();

        }
        internal void RemoverTarefa()
        {
            if (tarefas.Count > 0)
            {

                while (true)
                {
                    Console.Clear();
                    ListarTarefas();

                    Console.WriteLine("\nSelecione o Id da tarefa que deseja remover...\n");
                    bool isInt = (int.TryParse(Console.ReadLine(), out idTarefa));

                    if (!isInt || idTarefa <= 0) Console.WriteLine("\nId inválido!\n");

                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        if (tarefas[i].Id == idTarefa)
                        {
                            tarefas.RemoveAt(i);
                            SalvarTarefas();
                            Console.WriteLine("\nTarefa Removida com sucesso!\n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nId inválido");
                            break;
                        }
                    }

                    ReorganizarIds();

                    if(tarefas.Count == 0)
                    {
                        Console.WriteLine("Não há mais tarefas para serem removidas");
                        break;
                    }

                    Console.WriteLine("\nDeseja excluir outra tarefa? \n[S]im \n[N]ão\n");
                    string escolha = Console.ReadLine().ToLower();

                    if(!escolha.StartsWith("s"))
                    {
                        break;
                    }

                }
            }
            else
            {
                Console.WriteLine("\nNão existem itens que possam ser removidos!\n");
            }
        }

        internal void EditarTarefa()
        {
            if (tarefas.Count > 0)
            { 
                while (true)
                {
                    Console.Clear();
                    ListarTarefas();

                    Console.WriteLine("\nSelecione o Id da tarefa que deseja editar.\n");
                    bool isInt = int.TryParse(Console.ReadLine(), out idTarefa);
                    if (!isInt || idTarefa <= 0)
                    {
                        Console.WriteLine("\nId inválido!\n");
                        return;
                    }

                    bool encontrou = false;

                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        if (tarefas[i].Id == idTarefa)
                        {
                             encontrou = true;

                            Console.WriteLine("\nDigite o novo nome da tarefa, se preferir manter o mesmo nome" +
                                " digite apenas enter...\n");

                            string novoNome = Console.ReadLine();

                            if (!string.IsNullOrWhiteSpace(novoNome))
                            {
                                tarefas[i].Nome = novoNome;
                            }

                            Console.WriteLine("\nDigite a nova descrição, se preferir manter a mesma descrição" +
                                " digite apenas enter...\n");

                            string novaDesc = Console.ReadLine();

                            if (!string.IsNullOrWhiteSpace(novaDesc))
                            {
                                tarefas[i].Descricao = novaDesc;
                            }

                            Console.WriteLine("\nDeseja alterar o status de alguma tarefa? \n[S]im" +
                                "\n[N]ão\n");

                            string alterarStatus = Console.ReadLine().ToLower();

                            if (alterarStatus.StartsWith("s"))
                            {
                                if (tarefas[i].Concluida)
                                {
                                    Console.WriteLine("\nDeseja alterar o status da tarefa de 'Concluída' para 'Pendente'? \n[S]im\n[N]ão\n");
                                    if (Console.ReadLine().ToLower().StartsWith("s"))
                                    {
                                        tarefas[i].Concluida = false;
                                        Console.WriteLine("\nStatus alterado de 'Concluída' para 'Pendente'...");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nDeseja alterar o status da tarefa de 'Pendente' para 'Concluída'? \n[S]im\n[N]ão\n");
                                    if (Console.ReadLine().ToLower().StartsWith("s"))
                                    {
                                        tarefas[i].Concluida = true;
                                        Console.WriteLine("\nStatus alterado de 'Pendente' para 'Concluída'...\n");

                                    }
                                }
                            }
                            SalvarTarefas();
                                break; 
                        }
                        
                    }
                    if (!encontrou)
                    {
                        Console.WriteLine("\nId não encontrado\n");
                    }
                        
                    Console.WriteLine("\nDeseja editar mais tarefas? \n[S]im\n[N]ão\n");
                    string escolha = Console.ReadLine().ToLower();

                    if (!escolha.StartsWith("s")) break;

                }
            }
        }
        internal void ListarTarefas()
        {
            Console.Clear();
            CarregarTarefas();

            foreach(Tarefa item in tarefas)
            {
                string status = item.Concluida ? "Concluída" : "Pendente";
                Console.WriteLine($"{item.Id} - {item.Nome} - {item.Descricao} - {status}\n");
            }
        }

        internal void Sair()
        {
            Console.Clear();
            Console.WriteLine("\nSaindo do programa...");
            Environment.Exit(0);
        }

        internal void MarcarComoConcluida()
        {
            Console.Clear();
            ListarTarefas();

            if(tarefas.Count > 0)
            {
                Console.WriteLine("Digite o Id da tarefa que deseja marcar como concluída: \n");
                bool isInt = int.TryParse(Console.ReadLine(), out idTarefa);

                if (!isInt || idTarefa <= 0) Console.WriteLine("Digite um Id válido!\n");

                for(int i = 0; i < tarefas.Count; i++)
                {
                    if (tarefas[i].Id == idTarefa)
                    {
                        if (!tarefas[i].Concluida)
                        {
                            tarefas[i].Concluir();
                        }
                        else
                        {
                            Console.WriteLine("Essa tarefa já foi marcada como concluída\n");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Não há tarefas que possam ser marcadas\n");
            }
        }
        internal void ReorganizarIds()      
        {
            for(int i = 0; i < tarefas.Count; i++)
            {
                tarefas[i].Id = i + 1;
            }
            idTarefa = tarefas.Count > 0 ? tarefas.Last().Id + 1 : 1;
        }

        private readonly string caminhoArquivo = "tarefas.json";

        internal void SalvarTarefas()
        {
            string json = JsonSerializer.Serialize(tarefas, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(caminhoArquivo, json);
        }

        internal void CarregarTarefas()
        {
            if (File.Exists(caminhoArquivo))
            {
                string json = File.ReadAllText(caminhoArquivo);
                tarefas = JsonSerializer.Deserialize<List<Tarefa>>(json) ?? new List<Tarefa>();

                ReorganizarIds();
            }
        }
    }

}   

