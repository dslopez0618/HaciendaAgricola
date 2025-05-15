namespace HaciendaAgricola.Models;

public class LaborAgricola
{
    public int Id { get; set; }
    public string Tipo { get; set; }
    public DateTime Fecha { get; set; }
    public int CultivoId { get; set; }
    public Cultivo Cultivo { get; set; }
    public List<InsumoLabor> InsumosUsados { get; set; } = new List<InsumoLabor>();
    public List<PersonalLabor> PersonalAsignado { get; set; } = new List<PersonalLabor>();
}