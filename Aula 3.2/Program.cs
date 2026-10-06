class Program
{
    static void Main(string[] args)
    {
        double n1 = 9, n2 = 7, n3 = 5;     // Ex. 1
        // double n1 = 4, n2 = 5, n3 = 3;  // Ex. 2

        double media = (n1+n2+n3)/3;
        string situacao;

        if (media >= 7)
        {
            situacao = "Aprovado";
        }
        else if (media >= 5)
        {
            situacao = "Recuperação";
        }
        else
        {
            situacao = "Reprovado";
        }

        Console.WriteLine($"Média: {media} / Situação: {situacao}");
    }
}
