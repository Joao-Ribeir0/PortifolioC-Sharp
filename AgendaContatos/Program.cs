using System.Threading.Tasks;

namespace AgendaContatos
{
    class Program
    {
        static Metodos metodo = new Metodos();
        static async Task Main()
        {
            metodo.CarregarContatos();

            Console.WriteLine("Bem vindo! Pressione qualquer tecla e abra sua lista de contatos...");
            Console.ReadKey();

            await ContagemRegressiva();

            while (true)
            {
                Console.WriteLine("O que deseja fazer?\n" +
                "[1] - Listar Contatos\n" +
                "[2] - Cadastrar Contatos\n" +
                "[3] - Remover Contatos\n" +
                "[4] - Buscar contatos por nome\n" +
                "[5] - Buscar contatos por telefone\n" +
                "[6] - Ordenar Contatos\n" +
                "[7] - Sair\n ");

                int escolha;

                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch (escolha)
                    {
                        case 1:
                            metodo.ListarContatos();
                            break;
                        case 2:
                            metodo.CadastrarContato();
                            break;
                        case 3:
                            metodo.RemoverContato();
                            break;
                        case 4:
                            metodo.BuscarContatoPorNome();
                            break;
                        case 5:
                            metodo.BuscarContatoPorTelefone();
                            break;
                        case 6:
                            metodo.OrdenarContatos();
                            break;
                        case 7:
                            Console.WriteLine("Saindo...");
                            await Task.Delay(2000);
                            return;
                        default:
                            Console.WriteLine("Selecione uma opção válida!");
                            break; ;

                    }
                }
            }        
        }

        static async Task ContagemRegressiva()
        {
            for(int i = 5; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"Abrindo em {i} segundos...");
                await Task.Delay(1000);
            }
        }
    }
}


