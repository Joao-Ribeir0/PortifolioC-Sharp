using System.Numerics;
using System.Reflection;

int numero;
while (true)
{
    Console.WriteLine("Digite um número inteiro: ");

    bool intNumero = int.TryParse(Console.ReadLine(), out numero);

    if (intNumero)
    {
        break;
    }
    else
    {
        Console.WriteLine("Por favor, digite um número inteiro!");
    }
}

BigInteger CalcularFatorial(int numero)
{
    if (numero == 0)
    {
        return 1;
    }

    return numero * CalcularFatorial(numero - 1);
}

Console.WriteLine($"O fatorial de {numero} é {CalcularFatorial(numero)}");

      