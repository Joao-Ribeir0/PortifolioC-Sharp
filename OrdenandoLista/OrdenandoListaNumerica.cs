
List<int> numeros = new List<int>();
int numero;

while (true)
{
    Console.WriteLine("Digite números e vamos ordená-los em ordem crescente e colocá-los em uma lista para você: ");
    bool isint = int.TryParse(Console.ReadLine(), out numero);

    numeros.Add(numero);

    if(numeros.Count == 6)
    {
        break;
    }
}

Console.WriteLine();
void OrdenadorDeListasNumericas(List<int> lista)
{
    for(int i = 0; i < lista.Count; i++)
    {
        for(int j = i + 1; j < lista.Count; j++)
        {
            if (lista[i] > lista[j])
            {

                int temp = lista[i];
                lista[i] = lista[j];
                lista[j] = temp;
            }
        }
    }
    foreach (int item in lista)
    {
        Console.WriteLine(item);
    }
}

OrdenadorDeListasNumericas(numeros);
