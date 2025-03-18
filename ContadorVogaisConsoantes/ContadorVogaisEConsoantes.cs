string frase;

Console.WriteLine("Esse programa conta a quantidade de vogais e consoantes de uma frase");
while (true)
{

    Console.WriteLine("Escreva uma palavra ou frase: ");
    frase = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(frase))
    {
        Console.WriteLine("Digite uma frase válida");
    }
    else
    {
        ContadorVogaisEConsoantes(frase);
        break; 
    }
}

void ContadorVogaisEConsoantes(string frase)
{
   frase.ToLower();
   int contadorVogais = 0;
   int contadorConsoantes = 0;

    for(int i = 0; i < frase.Length; i++)
    {
        if (frase[i] == ' ') continue;

        if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u')
        {
            contadorVogais += 1;
        }
        else
        {
            contadorConsoantes += 1;
        }
    }

    Console.WriteLine($"A frase {frase} possui {contadorVogais} vogais e {contadorConsoantes} consoantes");
}