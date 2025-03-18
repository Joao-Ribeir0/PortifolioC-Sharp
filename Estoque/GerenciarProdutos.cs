using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO; 


namespace Estoque
{
    class GerenciarProdutos
    {
        List<Produto> produtos = new List<Produto>();

        public void AdicionarProdutos()
        {
            int escolha;
            do
            {
                Console.WriteLine("O produto que você deseja adicionar já está no sistema?\n[1] - Sim\n[2] - Não");

                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch (escolha)
                    {
                        case 1:
                            AdicionarProdutoCadastrado();
                            break;

                        case 2:
                            AdicionarProdutoNaoCadastrado();
                            break;

                        default:
                            Console.WriteLine("Digite uma opção válida!");
                            break;
                    }
                }
            } while (escolha != 1 && escolha != 2);

            int opcao;

            do
            {
                Console.WriteLine("Deseja adicionar mais algum produto ao sistema?\n[1] - Sim\n[2] - Não");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Digite uma opção válida! 1 para sim e 2 para não!");
                }

            } while (opcao != 1 && opcao != 2);

            if(opcao == 1)
            {
                AdicionarProdutos();
            }
            if(opcao == 2)
            {
                Console.WriteLine("Não há mais produtos a serem adicionados!");
            }

            return;

        }
        public void RemoverProdutos()
        {
            if(produtos.Count > 0)
            {
                ListarProdutos();
                int num;

                do
                {
                    Console.WriteLine("Digite o número do produto que deseja remover: ");

                    if (!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > produtos.Count)
                    {
                        Console.WriteLine("Digite um número válido!");
                    }
                } while (num < 1 || num > produtos.Count);

                produtos.RemoveAt(num - 1);
                SalvarProdutos();

                Console.WriteLine("Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Não há produtos para se remover!");
            }

            int opcao;
            do
            {
                Console.WriteLine("Deseja remover mais algum produto do estoque?: \n[1] - Sim\n[2] - Não");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Faça uma escolha válida!");
                }
            } while (opcao != 1 && opcao != 2);

            if(opcao == 1)
            {
                RemoverProdutos();
            }

            if(opcao == 2)
            {
                Console.WriteLine("Não há mais produtos a serem adicionados");
            }

            return;
        }
        public void EditarProdutos()
        {
            if(produtos.Count > 0)
            {
                ListarProdutos();

                int num;

                do
                {
                    Console.WriteLine("Selecione o número do produto que deseja editar:");

                    if(!int.TryParse(Console.ReadLine(), out num))
                    {
                        Console.WriteLine("Digite um número válido!");
                    }
                    else if(num < 1 || num > produtos.Count)
                    {
                        Console.WriteLine("Esse número não corresponde a um produto da lista!");
                    }

                } while (num < 1 || num > produtos.Count);

                
                Console.WriteLine("O que você deseja alterar no produto?\n[1] - Nome\n[2] - Preço\n[3] - Descrição");
                int escolha;
                if(int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch (escolha)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Digite o novo nome do produto: ");
                            string nome = Console.ReadLine();
                            produtos[num - 1].Nome = nome;
                            SalvarProdutos();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Digite o novo preço do produto: ");
                            decimal preco = decimal.Parse(Console.ReadLine());
                            produtos[num - 1].Preco = preco;
                            SalvarProdutos();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("Digite o a nova descrição: ");
                            string descricao = Console.ReadLine();
                            produtos[num - 1].Descricao = descricao;
                            SalvarProdutos();
                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Lista vazia!");
            }
        }
        public void ListarProdutos()
        {
            if(produtos.Count > 0)
            {
                for(int i = 0; i < produtos.Count; i++)
                {
                    Console.WriteLine($"Id: {i + 1} | Nome: {produtos[i].Nome} | Descrição: {produtos[i].Descricao} | Preço: R${produtos[i].Preco:F2} | Quantidade Disponível: {produtos[i].QuantidadeDisponivel} | Disponivel: {produtos[i].Disponivel} | Data de entrada: {produtos[i].DataEntrada} | ");
                }
            }
            else
            {
                Console.WriteLine("Não há produtos para serem listados");
            }
        }

        private readonly string dadosProdutos = "produtos.json";
        public void SalvarProdutos()
        {
            string json = JsonSerializer.Serialize(produtos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(dadosProdutos, json);
        }
        public void CarregarProdutos()
        {
            if (File.Exists("produtos.json"))
            {
                string json = File.ReadAllText(dadosProdutos);
                produtos = JsonSerializer.Deserialize<List<Produto>>(json) ?? new List<Produto>();
            }
        }
        public void BuscarProdutos()
        {
            if (produtos.Count > 0)
            {
                Console.WriteLine("Digite o nome do produto");
                string nomeProduto = Console.ReadLine().ToLower();

                var resultadoPesquisa = produtos.Where(p => p.Nome.ToLower().Contains(nomeProduto)).ToList();

                if(resultadoPesquisa.Any())
                {
                    foreach(var produto in resultadoPesquisa)
                    {
                        Console.WriteLine($"{produto.Nome}");
                    }
                }
                else
                {
                    Console.WriteLine("Produto não encontrado!");
                }
            }
            else
            {
                Console.WriteLine("Lista vazia!");
            }
        }
        public void AdicionarProdutoCadastrado()
        {
            ListarProdutos();

            int num;

            do
            {
                Console.WriteLine("Digite o número do produto que deseja editar a quantidade: ");

                if(!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > produtos.Count)
                {
                    Console.WriteLine("Digite um valor correto!");
                }

            } while (num < 1 || num > produtos.Count); //Console.Readline só pode ser chamado 1 vez e ja foi chamado no if pra capturar a entrada!

            int qtd;

            do
            {
                Console.WriteLine($"Agora digite a quantidade que deseja adicionar ao produto {produtos[num - 1].Nome}!");

                if (!int.TryParse(Console.ReadLine(), out qtd))
                {
                    Console.WriteLine("Digite um valor válido!");
                }

            } while (qtd <= 0);

            produtos[num - 1].QuantidadeDisponivel += qtd;

            Console.WriteLine("Quantidade atualizada com sucesso");

            Console.WriteLine($"Produto {produtos[num - 1].Nome} | {produtos[num - 1].Preco} | {produtos[num - 1].Descricao}\n" +
                $"Data de entrada no sistema: {produtos[num - 1].DataEntrada} | Quantidade Disponível: {produtos[num - 1].QuantidadeDisponivel} | Disponibilidade: {produtos[num - 1].Disponivel} | Quantidade Adicionada: {qtd} ");

            return;
        }
        public void AdicionarProdutoNaoCadastrado()
        {
            string nome;
            decimal preco;
            string descricao;
            int quantidade;

            do
            {
                Console.WriteLine("Digite o nome do produto: ");
                nome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("Digite um nome válido!");
                }

            } while (string.IsNullOrWhiteSpace(nome));

            do
            {
                Console.WriteLine("Digite o preço do produto: ");

                if(!decimal.TryParse(Console.ReadLine(), out preco))
                {
                    Console.WriteLine("Digite um valor válido para o preço!");
                }

            } while (preco <= 0);

            do
            {
                Console.WriteLine("Descreva o produto: ");
                descricao = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(descricao))
                {
                    Console.WriteLine("Digite uma descrição para o produto!");
                }

            } while (string.IsNullOrWhiteSpace(descricao));

            do
            {
                Console.WriteLine("Digite a quantidade a ser adicionada: ");
                
                if(!int.TryParse(Console.ReadLine(), out quantidade))
                {
                    Console.WriteLine("Digite um valor válido para quantidade!");
                }

            } while (quantidade <= 0);

            Produto novoProduto = new Produto(nome, preco, quantidade, descricao);

            Console.WriteLine($"Produto {novoProduto.Nome} | {novoProduto.Preco} | {novoProduto.Descricao}\n" +
                $"Data de entrada no sistema: {novoProduto.DataEntrada} | Quantidade Disponível: {quantidade} Disponibilidade: {novoProduto.Disponivel} -> Cadastrado no Sistema");

            produtos.Add(novoProduto);

            return;
        }
    }
}
