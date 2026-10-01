using System;
namespace MeuPrograma
{
    // Exemplo didático procedural: dados simples e funções estáticas, sem classes de domínio.
    class Program
    {
        enum Opcao
        {
            Sair = 0,
            Somar = 1,
            Subtrair = 2,
            Multiplicar = 3,
            Dividir = 4,
            Potencia = 5,
            RaizQuadrada = 6,
            Fatorial = 7
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Calculadora didática em C# ===");
            Console.WriteLine("Procedural: as operações são funções separadas e os dados são variáveis locais.");
            Console.WriteLine("Isso permite estudar lógica e funções sem introduzir objetos, propriedades ou herança.\n\n");

            // Tipos de dados e variáveis
            bool continuar = true;

            while (continuar)
            {
                int contador = 0;
                foreach (Opcao op in Enum.GetValues(typeof(Opcao)))
                {
                    Console.Write($"{(int)op}-{op}  ");
                    contador ++;

                    if (contador % 7 == 0)
                    {
                        Console.WriteLine();
                    }
                }

                Console.WriteLine();
                Console.Write("Escolha: ");
                string entrada = Console.ReadLine() ?? "";

                if (!int.TryParse(entrada, out int valorOpcao) || !Enum.IsDefined(typeof(Opcao), valorOpcao))
                {
                    Console.WriteLine("\nOpção inválida.\n");
                    continue;
                }

                Opcao opcao = (Opcao)valorOpcao;

                if (opcao == Opcao.Sair)
                {
                    continuar = false;
                    break;
                }

                Calcular(opcao);
            }
        }

        static void Calcular(Opcao opcao)
        {
            try
            {
                var metodo = typeof(Program).GetMethod(
                    opcao.ToString(),
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic);

                var parametros = metodo!.GetParameters();
                object[] entradas = new object[parametros.Length];

                for (int i = 0; i < parametros.Length; i++)
                {
                    Console.Write($"Digite o número {i+1}: ");
                    entradas[i] = double.Parse(Console.ReadLine() ?? "");
                }

                var resultado = metodo.Invoke(null, entradas);

                Console.WriteLine($"Resultado: {resultado}\n\n");

            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite um número válido.\n");
            }
        }

        static double Somar(double a, double b)
        {
            return a + b;
        }

        static double Subtrair(double a, double b)
        {
            return a - b;
        }

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        static double Dividir(double a, double b)
        {
            return a / b;
        }

        static double Potencia(double a, double b)
        {
            return Math.Pow(a, b);
        }

        static double RaizQuadrada(double a)
        {
            return Math.Sqrt(a);
        }

        static double Fatorial(double a)
        {
            double valor = a;
            for (int i = (int)a - 1; i > 0; i--)
            {
                valor *= i;
            }
            return valor;
        }
    }
}