
using System.Runtime.CompilerServices;

string palavra;

Console.WriteLine("Esse programa inverte palavras!");

while (true)
{
    Console.WriteLine("Digite a palavra que deseja inverter: ");
    palavra = Console.ReadLine();

    Console.WriteLine($"A palavra {palavra} invertida fica {InvertePalavra(palavra)}");
}

string InvertePalavra(string palavra)
{
    string palavraInvertida = "";

    for(int i = palavra.Length - 1; i >= 0; i--)
    {
        palavraInvertida += palavra[i];
    }

    return palavraInvertida;
}