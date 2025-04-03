class Program
{
    static void Main()
    {
        int numero;

        Console.WriteLine("Detectaremos se um número é ou não é feliz");

        do
        {
            Console.WriteLine("Digite um número inteiro de até dois dígitos: ");

            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Digite somente um número inteiro");
                continue;
            }

            if (numero >= 100)
            {
                Console.WriteLine("O número contém mais de dois dígitos");
                continue;
            }

            break;
        } while (true);

        if (EhFeliz(numero))
        {
            Console.WriteLine($"O número {numero} é feliz!");
        }
        else
        {
            Console.WriteLine($"O número {numero} é infeliz!");
        }
    }

    static bool EhFeliz(int num)
    {
        HashSet<int> numeros = new HashSet<int>();

        while (num != 1 && numeros.Add(num)) 
        {
            num = SomaQuadrados(num);
        }

        return num == 1;
    }

    static int SomaQuadrados(int num)
    {
        int soma = 0;

        while (num > 0)
        {
            int digito = num % 10;
            soma += digito * digito;
            num /= 10;
        }

        return soma;
    }
}
