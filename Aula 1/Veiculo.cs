public abstract class Veiculo
{
    public String Marca {get; set;}
    public String Modelo {get; set;}
    public bool EstaLigado {get; set;}


    public Veiculo(String marca, String modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public void Ligar()
    {
        EstaLigado = true;
    }

    public void Desligar()
    {
        EstaLigado = false;
    }

    public abstract void Acelerar(int incremento);

    public abstract void Frear(int decremento);
}