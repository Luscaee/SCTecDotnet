class Program
{
    static void Main(string[] args)
    {
        int limite = 5000000;     // Exemplo 1
        // int limite = 10;  // Exemplo 2
        List<int> primos = new List<int>();
        int quantidade = 0;
        int soma = 0;

        for (int i = 0; i <= limite; i++)
        {
            if (EhPrimo(i))
            {
                primos.Add(i);
                quantidade++;
                soma += i;
            }
            // Console.WriteLine(EhPrimo(i));
        }

        Console.WriteLine($"Primos: {string.Join(", ", primos)} / Quantidade: {quantidade} / Soma: {soma}");
    }

    static bool EhPrimo(int numero)
    {
        if (numero < 2) return false;

        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }
}