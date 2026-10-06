class Program
{
    static void Main(string[] args)
    {
        // int n = 10;
        int n = 20;

        int somas = 0;
        int multiplos = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0) {
                somas += i;
            }
            if (i % 3 == 0)
            {
                multiplos++;
            }
        }

        Console.WriteLine($"Soma dos pares: {somas} / Múltiplos de 3:{multiplos}");
    }
}