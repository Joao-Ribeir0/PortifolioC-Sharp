using System.Reflection.Metadata.Ecma335;

namespace SistemaBancario2
{
    class Program
    {
        static Pessoa pessoa = new Pessoa();
        static Conta conta = new Conta();
        static void Main()
        {
            int escolha;

            Console.WriteLine("Olá, você já possui uma conta em nosso banco?");
            Console.WriteLine("Digite 1 ou 2 \n\n [1] - Sim \n [2] - Não");
            if (!int.TryParse(Console.ReadLine(), out escolha))
            {
                Console.WriteLine("Entrada inválida! Digite um número...");
                return;
            }

            switch (escolha)
            {
                case 1:
                    Console.Clear();
                    MenuLogin();
                    break;

                case 2:
                    CriarConta();
                    break;

                default:
                    Console.WriteLine("Selecione uma opção válida!");
                    break;
            }
        }

        static void MenuPrincipalCliente()
        {
            while (true)
            {
                int escolha;

                Console.WriteLine($"Olá {pessoa.Nome}, bem vindo(a) ao menu principal, selecione quais operações deseja realizar: \n" +
                    $"\n" +
                    $"[1] - Depositar\n" +
                    $"[2] - Sacar\n" +
                    $"[3] - Exibir saldo\n" +
                    $"[4] - Sair");

                if (!int.TryParse(Console.ReadLine(), out escolha))
                {
                    Console.WriteLine("Entrada inválida! Digite um número....");
                }   

                switch (escolha)
                {
                    case 1:
                        decimal valorDeposito;
                        Console.WriteLine("Digite o valor que deseja depositar: ");
                        bool isDecimal = decimal.TryParse(Console.ReadLine(), out valorDeposito);
                        if (!isDecimal)
                        {
                            Console.WriteLine("Valor inválido!");
                            return;
                        }
                        conta.Depositar(valorDeposito);
                        break;
                    case 2:
                        decimal valorSaque;
                        Console.WriteLine("Digite o valor que deseja sacar: ");
                        bool isDecimalSaque = decimal.TryParse(Console.ReadLine(), out valorSaque);
                        if (!isDecimalSaque)
                        {
                            Console.WriteLine("Valor inválido!");
                            return;
                        }
                        conta.Sacar(valorSaque);
                        break;
                    case 3:
                        conta.ExibirSaldo();
                        break;
                    case 4:
                        Console.WriteLine("Parece que sua operação foi concluída!");
                        Console.WriteLine("Saindo...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Digite uma opção que seja válida");
                        break;

                }
            }
            
        }

        static void CriarConta()
        {
            Console.WriteLine("Vamos Criar sua conta!");

            Console.WriteLine("Escreva seu nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Escreva seu Cpf");
            pessoa.Cpf = Console.ReadLine();

            Console.WriteLine("Escreva sua idade: ");
            pessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva uma senha: ");
            pessoa.Senha = Console.ReadLine();

            Console.WriteLine("Conta criada com sucesso!");
            Console.Clear();
            MenuLogin();

        }

        static void MenuLogin()
        {
            while (true)
            {
                Console.WriteLine("----- Login -----\n");
                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite agora sua senha: ");
                string senha = Console.ReadLine();
                if (senha == pessoa.Senha && nome == pessoa.Nome)
                {
                    MenuPrincipalCliente();
                }
                else
                {
                    Console.WriteLine("Dados de login inválidos!");
                    break;
                }

            }
           
        }
    }
}
