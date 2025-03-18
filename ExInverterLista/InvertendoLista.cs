List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6 };


void InverterLista(List<int> lista)
{
    List<int> novaLista = new List<int>();

    for(int i = lista.Count - 1; i >= 0; i--)
    {
        novaLista.Add(lista[i]);
    }

    foreach(int elemento in novaLista)
    {
        Console.Write(elemento);
    }

    
}

foreach(int elemento in lista)
{
    Console.Write(elemento);
}

Console.WriteLine("\n--------------------");

InverterLista(lista);
