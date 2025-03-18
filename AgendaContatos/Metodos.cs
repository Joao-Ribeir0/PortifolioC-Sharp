using System.Text.Json;
using System.Text.RegularExpressions;

namespace AgendaContatos
{
    internal class Metodos
    {
        public Dictionary<int, Contato> contatos = new Dictionary<int, Contato>();
        private int id = 1;
        public void CadastrarContato()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escreva o nome do contato que deseja adicionar: ");
                string nome = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("O nome do contato deve ser preenchido!");
                    continue;
                }

                Console.WriteLine("Digite o email do contato: ");
                string email = Console.ReadLine();

                Console.WriteLine("Digite o telefone do contato: ");
                string telefone = Console.ReadLine();

                try
                {
                    Contato novoContato = new Contato(nome, telefone, email);
                    contatos[id++] = novoContato;
                    Console.WriteLine("Contato cadastrado com sucesso!");
                    SalvarContatos();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao cadastar o contato!");
                }

                return;
            }
        }

        public void RemoverContato()
        {
            while (true)
            {
                if (contatos.Count > 0)
                {
                    Console.Clear();
                    ListarContatos();

                    Console.WriteLine("Selecione o Id do contato que deseja remover: ");
                    int idRemover;

                    if(int.TryParse(Console.ReadLine(), out idRemover) && contatos.ContainsKey(idRemover))
                    {
                        contatos.Remove(idRemover);
                        SalvarContatos();
                        Console.WriteLine($"Contato removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Id inválido ou não encontrado!");
                    }

                    return;
                }
                else
                {
                    Console.WriteLine("Não existem contatos para serem removidos...");
                }
                return;
            }
        }

        public void ListarContatos()
        {
            Console.Clear();

            foreach(var contato in contatos)
            {
                Console.WriteLine($"{contato.Key} - Nome: {contato.Value.Nome}\n{contato.Value.Telefone}\n{contato.Value.Email}");
                Console.WriteLine("__________________________________________");
            }   
        }

        private readonly string caminhoArquivo = "contatos.json"; 
        public void CarregarContatos() 
        {
            if (File.Exists(caminhoArquivo))
            {
                string json = File.ReadAllText(caminhoArquivo);
                contatos = JsonSerializer.Deserialize<Dictionary<int, Contato>>(json) ?? new Dictionary<int, Contato>();
            }
        }

        public void SalvarContatos()
        {
            string json = JsonSerializer.Serialize(contatos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(caminhoArquivo, json);
        }

        public void OrdenarContatos()
        {
            if(contatos.Count > 0)
            {
                var contatosOrdenados = contatos.OrderBy(c => c.Value.Nome).ToList();

                Console.WriteLine("Contatos ordenados por nome:");

                foreach (var contato in contatosOrdenados)
                {
                    Console.WriteLine($"{contato.Key} - Nome: {contato.Value.Nome}\n{contato.Value.Telefone}\n{contato.Value.Email}\n");
                }
                return;
            }
            else
            {
                Console.WriteLine("Não existem contatos na lista!");
                return;
            }
            
        }

        public void BuscarContatoPorNome()
        {
            if (contatos.Count > 0)
            {
                Console.Clear();

                Console.WriteLine("Digite o nome do contato que está procurando: \n");
                string nome = Console.ReadLine();

                foreach(var contato in contatos)
                {
                    if(contato.Value.Nome == nome)
                    {
                        Console.WriteLine($"{contato.Key} - Nome: {contato.Value.Nome}\n{contato.Value.Telefone}\n{contato.Value.Email}\n");
                    }
                }

            }
            return;
        }
        
        public void BuscarContatoPorTelefone()
        {
            if (contatos.Count > 0)
            {
                Console.Clear();

                Console.WriteLine("Digite o telefone do contato que está procurando: \n");
                string telefone = Console.ReadLine();

                foreach (var contato in contatos)
                {
                    if (contato.Value.Telefone == telefone)
                    {;
                        Console.WriteLine($"{contato.Key} - Nome: {contato.Value.Nome}\n{contato.Value.Telefone}\n{contato.Value.Email}\n");
                    }
                }

            }
            return;
        }
    }
}