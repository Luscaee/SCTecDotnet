public class Transacao
{
    public int Id { get; set; }
    public string Descricao { get; set; } = "";
    public string Tipo { get; set; } = "Depósito";
    public decimal Valor { get; set; }
    public DateTime Data { get; set; } = DateTime.Now;
    public int ContaId { get; set; }
    public Conta? Conta { get; set; }
}