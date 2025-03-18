
double numero;

while (true)
{
    Console.WriteLine("Digite um número e verifique se ele é par ou ímpar: ");
    bool isDouble = double.TryParse(Console.ReadLine(), out numero);

    if (!isDouble)
    {
        Console.WriteLine("Digite somente um número");
    }
    else
    {
        ParOuImpar(numero);
        break;
    }
}
void ParOuImpar(double num)
{
    if(num % 2 == 0)
    {
        Console.WriteLine($"O número {num} é par");
    }
    else
    {
        Console.WriteLine($"O número {num} é ímpar");
    }
}

