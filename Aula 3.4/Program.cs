class Program
{
    static void Main(string[] args)
    {
        // int[] numeros = { 4, 9, 2, 15, 10};
        int[] numeros = { 5, 5, 5, 5 };
        int maior = 0;
        int menor = numeros[0];
        double media = numeros.Average();
        int acima = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] > maior) maior = numeros[i];
            if (numeros[i] < menor) menor = numeros[i];
            if (numeros[i] > media) acima++;
        }

        Console.WriteLine($"Maior: {maior} / Menor: {menor} / Média: {media} / Acima da média: {acima}");
    }
}