namespace Estoque
{
    class Program
    {
        static GerenciarFuncionarios gerenciarFuncionarios = new GerenciarFuncionarios();
        static GerenciarProdutos gerenciarProdutos = new GerenciarProdutos();
        static string senha;
        static string nome;
        static int escolha;
        static void Main()
        {
            gerenciarFuncionarios.CarregarDados();

            MenuPrincipal();
        }

        static void MenuPrincipal()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("         Tela de login");
                Console.WriteLine("-------------------------------------");

                do
                {
                    Console.WriteLine("Você já possui cadastro?\n[1] - Sim\n[2] - Não\n");

                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out escolha) || escolha != 1 && escolha != 2)
                    {
                        Console.WriteLine("Digite 1 ou 2!");
                    }

                } while (escolha != 1 && escolha != 2);

                if (escolha == 1)
                {
                    Console.WriteLine("Faça seu login: ");

                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine();

                    Console.WriteLine("Senha: ");
                    senha = Console.ReadLine();

                    Funcionario funcionarioLogado = gerenciarFuncionarios.VerificarCredenciais(nome, senha);


                    if (funcionarioLogado != null)
                    {
                        if (funcionarioLogado.Cargo.ToLower() == "gerente")
                        {
                            Console.WriteLine($"Acesso concedido ao gerente ({funcionarioLogado.Nome})");
                            MenuGerente();
                        }
                        else
                        {
                            Console.WriteLine($"Acesso concedido ao vendedor {funcionarioLogado.Nome}");
                            MenuVendedor();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Funcionário não cadastrado!");
                        continue;
                    }
                }

                if (escolha == 2)
                {
                    gerenciarFuncionarios.CadastrarFuncionario();
                    continue;
                }

                int opcao;
                do
                {
                    Console.WriteLine("Deseja fechar o programa?\n[1] - Sim\n[2] - Não");
                } while (!int.TryParse(Console.ReadLine(), out opcao));

                switch (opcao)
                {
                    case 1:
                        Environment.Exit(0);
                        break;
                    case 2:
                        MenuPrincipal();
                        break;
                    default:
                        Console.WriteLine("Selecione uma opção válida!");
                        continue;
                }



            }
        }
        static void MenuVendedor()
        {
            while (true)
            {
                int escolha;
                do
                {
                    Console.WriteLine($"Olá! Qual das operações abaixo deseja realizar?");

                    Console.WriteLine("\n[1] - Adicionar Produtos" +
                    "\n[2] - Remover Produtos" +
                    "\n[3] - Editar Produtos" +
                    "\n[4] - Listar Produtos" +
                    "\n[5] - BuscarProdutos");
                } while (!int.TryParse(Console.ReadLine(), out escolha));


                switch (escolha)
                {
                    case 1:
                        gerenciarProdutos.AdicionarProdutos();
                        break;

                    case 2:
                        gerenciarProdutos.RemoverProdutos();
                        break;

                    case 3:
                        gerenciarProdutos.EditarProdutos();
                        break;

                    case 4:
                        gerenciarProdutos.ListarProdutos();
                        break;

                    case 5:
                        gerenciarProdutos.BuscarProdutos();
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        continue;
                }
            }
        }

        static void MenuGerente()
        {
            while (true)
            {
                int escolha;
                do
                {
                    Console.WriteLine($"Olá! Qual das operações abaixo deseja realizar?");

                    Console.WriteLine("\n[1] - Adicionar Produtos" +
                    "\n[2] - Remover Produtos" +
                    "\n[3] - Editar Produtos" +
                    "\n[4] - Listar Produtos" +
                    "\n[5] - BuscarProdutos" +
                    "\n[6] - Remover Funcionário" +
                    "\n[7] - Editar Dados de um Funcionário" +
                    "\n[8] - Listar Funcionários" +
                    "\n[9] - Buscar Funcionários por Nome" +
                    "\n[10] - Buscar Funcionários por Cargo" +
                    "\n[11] - Ordenar Funcionários(A-Z)");
                } while (!int.TryParse(Console.ReadLine(), out escolha));


                switch (escolha)
                {
                    case 1:
                        gerenciarProdutos.AdicionarProdutos();
                        break;

                    case 2:
                        gerenciarProdutos.RemoverProdutos();
                        break;

                    case 3:
                        gerenciarProdutos.EditarProdutos();
                        break;

                    case 4:
                        gerenciarProdutos.ListarProdutos();
                        break;

                    case 5:
                        gerenciarProdutos.BuscarProdutos();
                        break;

                    case 6:
                        gerenciarFuncionarios.DeletarFuncionario();
                        break;

                    case 7:
                        gerenciarFuncionarios.EditarFuncionario();
                        break;

                    case 8:
                        gerenciarFuncionarios.ListarFuncionarios();
                        break;

                    case 9:
                        gerenciarFuncionarios.BuscarFuncionarioPorNome();
                        break;

                    case 10:
                        gerenciarFuncionarios.BuscarFuncionarioPorCargo();
                        break;

                    case 11:
                        gerenciarFuncionarios.OrdenarFuncionariosAZ();
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        continue;
                }
            }
        }
    }
}