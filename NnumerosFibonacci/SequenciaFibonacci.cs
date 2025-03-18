using System.Runtime.CompilerServices;

Console.WriteLine("Esse programa retorna os N primeiros números da Sequência de Fibonacci");

int posicao;

while (true)
{
    Console.WriteLine("Digite até qual posição você deseja saber da Sequência de Fibonacci");
    bool isInt = int.TryParse(Console.ReadLine(), out posicao);

    if (!isInt)
    {
        Console.WriteLine("Digite um número inteiro");
    }
    else
    {
        Console.WriteLine($"Os {posicao} primeiros números da sequência de Fibonacci são: ");
        break;
    }
}


void SequenciaFibonacci(int posicao)
{
    int numeroAnterior = 0;
    int numeroAtual = 1;

    Console.WriteLine(0);
    Console.WriteLine(1);

    for (int i = 3; i <= posicao; i++)
    {
        int numeroSeguinte = numeroAnterior + numeroAtual;
        numeroAnterior = numeroAtual;
        numeroAtual = numeroSeguinte;
        Console.WriteLine(numeroAtual);
    }
}

SequenciaFibonacci(posicao);