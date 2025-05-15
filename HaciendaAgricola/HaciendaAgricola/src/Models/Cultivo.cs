namespace HaciendaAgricola.Models;

public class Cultivo
{
    public int Id { get; set; }
    public string Tipo { get; set; }
    public string Variedad { get; set; }
    public DateTime FechaSiembra { get; set; }
    public int ParcelaId { get; set; }
    public Parcela Parcela { get; set; }
    public List<LaborAgricola> Labores { get; set; } = new List<LaborAgricola>();
}