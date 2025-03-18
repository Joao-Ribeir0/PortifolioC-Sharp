string palavra;

Console.WriteLine("Digite uma palavra: ");
palavra = Console.ReadLine();

bool VerificaPalindromo(string palavra)
{
    string palavraInvertida = "";
    int tamanhoPalavra = palavra.Length;

    for(int i = tamanhoPalavra - 1; i >= 0; i--)
    {
        palavraInvertida += palavra[i];
    }

    

    return palavraInvertida == palavra;

}

if (VerificaPalindromo(palavra))
{
    Console.WriteLine($"A palavra '{palavra}' é um palíndromo");
}
else
{
    Console.WriteLine($"A palavra '{palavra}' não é um palíndromo");
}