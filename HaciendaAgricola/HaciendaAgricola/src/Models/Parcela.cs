namespace HaciendaAgricola.Models;

public class Parcela
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public double AreaHectareas { get; set; }
    public string TipoSuelo { get; set; }
    public string HistorialUso { get; set; }
    public List<Cultivo> Cultivos { get; set; } = new List<Cultivo>();
}