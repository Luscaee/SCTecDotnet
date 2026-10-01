public class Carro{
    public long Id {get; set;}
    public String Marca {get; set;}
    public int Ano {get; set;}
    public String Cor {get; set;}
    public int Velocidade {get; set;}
    public bool EstaLigado {get; set;}

    public Carro()
    {
        Id = 0;
        Marca = "teste";
        Ano = 0;
        Cor = "teste";
        Velocidade = 0;
        EstaLigado = true;
    }

    public Carro(long id, String marca, int ano, String cor, int velocidade, bool estaLigado)
    {
        Id = id;
        Marca = marca;
        Ano = ano;
        Cor = cor;
        Velocidade = velocidade;
        EstaLigado = estaLigado;
    }
    public void Acelerar(int incremento)
    {
        if (EstaLigado)
        {
            Velocidade += incremento;
        }
    }

    public void Frear(int decremento)
    {
        if (EstaLigado)
        {
            Velocidade -= decremento;
            if (Velocidade < 0)
            {
                Velocidade = 0;
            }
        }
    }

    public void Buzinar()
    {
        if (EstaLigado)
        {
            Console.WriteLine("Buzinando!");
        } else
        {
            Console.WriteLine("O carro está desligado");
        }
    }
}