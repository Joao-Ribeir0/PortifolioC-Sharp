int numero;
while (true) 
{
    while (true)
    {

        Console.WriteLine("Digite um número e vamos verificar se ele é primo: ");
        bool isInt = int.TryParse(Console.ReadLine(), out numero);

        if (isInt && numero != 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Digite um número inteiro diferente de zero!");
        }
    }

    bool VerificaPrimos() 
    {
        if (numero < 2 ) return false; // não é primo
        if (numero == 2) return true; // é primo
        if (numero % 2 == 0) return false; // não é primo 
     
        for(int i = 2; i < numero; i++)
        {
            if(numero % i == 0)
            {
                return false; // não é primo
            }
        }
        return true; // é primo
    }

    if (VerificaPrimos())
    {
        Console.WriteLine($"o número {numero} é primo");
    }
    else
    {
        Console.WriteLine($"o número {numero} não é primo");

    }

    Console.WriteLine("Deseja continuar verificando números primos? [S]im   /   [N]ão");
    string sair = (Console.ReadLine()).ToLower();

    if (sair == "n") break;
}
