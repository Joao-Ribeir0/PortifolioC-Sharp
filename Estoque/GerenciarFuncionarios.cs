    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.Json;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.IO; 


namespace Estoque
    {
        class GerenciarFuncionarios
        {
            public List<Funcionario> funcionarios = new List<Funcionario>();
            public void CadastrarFuncionario() 
            {
                while (true)
                {
                    Console.Clear();

                    Console.WriteLine("Faça o cadastro do funcionário abaixo");
                    Console.WriteLine("--------------------------------------------------");

                    string nome;
                    int idade;
                    string senha;
                    string cpf;

                    do
                    {
                        Console.WriteLine("Digite um nome e sobrenome: ");
                        nome = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(nome));

                    do
                    {
                        Console.WriteLine("Digite a idade: ");
                    } while (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0);

                    do
                    {
                        Console.WriteLine("Informe a senha do usuário para acessar o sistema: ");
                        senha = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(senha));

                    do
                    {
                        Console.WriteLine("Digite o Cpf do funcionário: "); //Implementar Regex para requerir um formato válido de cpf
                        cpf = Console.ReadLine();
                        cpf = FormatarCpf(cpf);
                    } while (cpf.Length != 14);                

                    string cargo = "";
                    while (true)
                    {
                        Console.WriteLine("Pressione 1 ou 2 conforme as opções a seguir: \n[1] - O funcionário em questão é um vendedor.\n[2] - O funcionário em questão é um gerente.");
                        int escolha;
                        if (!int.TryParse(Console.ReadLine(), out escolha))
                        {
                            Console.WriteLine("Faça uma escolha válida!");
                            continue;
                        }
                        switch (escolha)
                        {
                            case 1:
                                cargo = "vendedor";
                                break;
                            case 2:
                                cargo = "gerente";
                                break;
                            default:
                                Console.WriteLine("Por favor, faça uma escolha válida!");
                                continue;
                        }
                        break;
                    }
                    Funcionario novoFuncionario = new Funcionario(nome, idade, senha, cpf, cargo);
                    funcionarios.Add(novoFuncionario);
                    Console.WriteLine("Aqui estão os dados do funcionário: \n");
                    Console.WriteLine("Nome: " + novoFuncionario.Nome);
                    Console.WriteLine("Idade: " + novoFuncionario.Idade);
                    Console.WriteLine("Senha: " + novoFuncionario.Senha);
                    Console.WriteLine("Cpf: " + novoFuncionario.Cpf);
                    Console.WriteLine("Cargo: " + novoFuncionario.Cargo);
                    SalvarDados();
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    return;
                }

            }


            private readonly string dadosFuncionarios = "funcionarios.json";
            public void SalvarDados()
            {
                string json = JsonSerializer.Serialize(funcionarios, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(dadosFuncionarios, json);
            }
            public void CarregarDados()
            {
                if (File.Exists(dadosFuncionarios))
                {
                    string json = File.ReadAllText(dadosFuncionarios);
                    funcionarios = JsonSerializer.Deserialize<List<Funcionario>>(json) ?? new List<Funcionario>();
                }
            }
            public void ListarFuncionarios()
            {
                if (funcionarios.Count > 0)
                {
                    Console.Clear();

                    int contador = 0;

                    for(int i = 0; i < funcionarios.Count; i++)
                    {
                        contador++;
                        Console.WriteLine($"{contador} - Nome: {funcionarios[i].Nome}, Idade: {funcionarios[i].Idade}, Cargo: {funcionarios[i].Cargo}");
                    }
                }
            }    
            public void DeletarFuncionario()
            {
                if(funcionarios.Count > 0)
                {
                    Console.Clear();
                    ListarFuncionarios();
                    bool funcionarioRemovido = false;
                    while(!funcionarioRemovido)
                    {
                        int num;

                        do
                        {
                            Console.WriteLine("Digite o número do usuário a ser removido: ");

                        }   while (!int.TryParse(Console.ReadLine(), out num) || num <= 0 || num > funcionarios.Count);
                                  
                        if (num > 0 && num <= funcionarios.Count)
                        {
                            Console.WriteLine("Funcionario removido com sucesso!");
                            funcionarios.RemoveAt(num - 1);
                            SalvarDados();
                            funcionarioRemovido = true;
                        }
                        else
                        {
                            Console.WriteLine("Número inválido! Tente novamente...");
                        }
                    
                    }

                    return;
                }
                else
                {
                    Console.WriteLine("Não existem funcionários para se remover!");
                }
                return;
            }
            public void EditarFuncionario()
            {
                if(funcionarios.Count > 0)
                {
                    Console.Clear();
                    ListarFuncionarios();
                    int num;
                    bool edicaoConcluida = false;
                    int numeroEscolha;
                    do
                    {
                        Console.WriteLine("Digite o numero do funcionario que deseja editar: ");
                        bool isInt = int.TryParse(Console.ReadLine(), out num);

                        if (num > 0 && num <= funcionarios.Count && isInt)
                        {
                            var funcionario = funcionarios[num - 1];
                                do
                                {
                                    Console.WriteLine("O que você deseja editar? " +
                                    "\n[1] - Modificar nome" +
                                    "\n[2] - Modificar idade" +
                                    "\n[3] - Modificar senha" +
                                    "\n[4] - Modificar cpf" +
                                    "\n[5] - Modificar cargo");
                                } while (!int.TryParse(Console.ReadLine(), out numeroEscolha) || numeroEscolha < 1 || numeroEscolha > 5);

                                switch (numeroEscolha)
                                {
                                    case 1:
                                        string nome;
                                        do
                                        {
                                            Console.WriteLine("Digite o novo nome: ");
                                            nome = Console.ReadLine();
                                        } while (string.IsNullOrWhiteSpace(nome));
                                        funcionario.Nome = nome;
                                        SalvarDados();
                                        break;

                                    case 2:
                                        int idade;
                                        do
                                        {
                                            Console.WriteLine("Digite a nova idade: ");
                                        } while (!int.TryParse(Console.ReadLine(), out idade));
                                        funcionario.Idade = idade;
                                        SalvarDados();
                                        break;

                                    case 3:
                                        string senha;
                                        do
                                        {
                                            Console.WriteLine("Digite a nova senha: ");
                                            senha = Console.ReadLine();
                                        } while (string.IsNullOrWhiteSpace(senha));
                                        funcionario.Senha = senha;
                                        SalvarDados();
                                        break;

                                    case 4:
                                        string cpf;
                                        do
                                        {
                                            Console.WriteLine("Digite o novo cpf: ");
                                            cpf = Console.ReadLine();
                                            cpf = FormatarCpf(cpf);
                                        } while (cpf.Length != 14);
                                        funcionario.Cpf = cpf;
                                        SalvarDados();
                                        break;

                                    case 5:
                                        string cargo;
                                        do
                                        {
                                            Console.WriteLine("Digite o novo cargo: (vendedor ou gerente)");
                                            cargo = Console.ReadLine().ToLower();
                                        } while (cargo != "vendedor" && cargo != "gerente");
                                        funcionario.Cargo = cargo;
                                        SalvarDados();
                                        break;

                                    default:
                                        Console.WriteLine("Escolha uma opção válida!");
                                        continue;
                                }

                                int escolha;
                                do
                                {

                                    Console.WriteLine("Você deseja editar mais alguma coisa?" +
                                    "\n[1] - Sim\n[2] - Não");
                                } while (!int.TryParse(Console.ReadLine(), out escolha));

                                switch (escolha)
                                {
                                    case 1:
                                        Console.WriteLine("Vamos editar novamente!");
                                        break;
                                    case 2:
                                        Console.WriteLine("Saindo...");
                                        edicaoConcluida = true;
                                        break;
                                }
                        }
                        else
                        {
                            Console.WriteLine("Número inválido!");
                            break;
                        }
                        
                    } while (!edicaoConcluida);
                
                }
                else
                {
                    Console.WriteLine("Não existem funcionários para terem os dados editados");
                }
                return;
            }
            public void BuscarFuncionarioPorNome()
        {
            if (funcionarios.Count > 0)
            {
                while (true)
                {
                    Console.WriteLine("Digite o nome do funcionario: ");
                    string nomeBusca = Console.ReadLine();
                    bool funcionarioEncontrado = false;

                    for (int i = 0; i < funcionarios.Count; i++)
                    {
                        if (funcionarios[i].Nome == nomeBusca)
                        {

                            Console.WriteLine(funcionarios[i].Nome);
                            funcionarioEncontrado = true;
                            break;
                        }
                    }

                    if (!funcionarioEncontrado) Console.WriteLine("Funcionário não encontrado!");

                    Console.WriteLine("Deseja buscar outro funcionário? " +
                        "\n[1] - Sim " +
                        "\n[2] - Não");

                    int escolha;
                    if (int.TryParse(Console.ReadLine(), out escolha))
                    {
                        switch (escolha)
                        {
                            case 1:
                                Console.Clear();
                                break;

                            case 2:
                                Console.WriteLine("Voltando para o menu principal!");
                                return;

                            default:
                                Console.WriteLine("Escolha uma opção válida!");
                                continue;
                        }
                    }

                }
            }
        }
            public void BuscarFuncionarioPorCargo()
            {
                if(funcionarios.Count > 0)
                {
                    string cargo;
                    do
                    {
                        Console.WriteLine("Digite o cargo do funionário que você deseja encontrar: ");
                        cargo = Console.ReadLine().ToLower();
                    } while (cargo != "vendedor" && cargo != "gerente");

                    foreach(var funcionario in funcionarios)
                    {
                        if(funcionario.Cargo == cargo)
                        {
                            Console.WriteLine($"Nome: {funcionario.Nome}, Cargo: {funcionario.Cargo}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Não existem funcionários para procurar");
                }
                    Console.WriteLine("Pressione qualquer tecla e volte para o menu principal!");
        }
            public void OrdenarFuncionariosAZ()
            {
                if(funcionarios.Count > 0)
                {
                    var funcionariosOrdenados = funcionarios.OrderBy(n => n.Nome).ToList();

                    Console.WriteLine("Lista em ordem alfabética: ");

                    foreach(var funcionario in funcionariosOrdenados)
                    {
                        Console.WriteLine($"Nome: {funcionario.Nome} - Idade: {funcionario.Idade}");
                    }
                }
                else
                {
                    Console.WriteLine("Lista vazia!");
                }
            }
            public string FormatarCpf(string cpf)
            {
                cpf = Regex.Replace(cpf, @"\D", ""); //remove os caracteres não numéricos

                return Regex.Replace(cpf, @"(\d{3})(\d{3})(\d{3})(\d{2})", "$1.$2.$3-$4");
            }
            public Funcionario VerificarCredenciais(string nome, string senha)
            {
                return funcionarios.FirstOrDefault(f => f.Nome == nome && f.Senha == senha);
            }

    
        }
    }
