namespace HaciendaAgricola.Models;

public class PersonalLabor
{
    public int LaborAgricolaId { get; set; }
    public LaborAgricola LaborAgricola { get; set; }
    public int PersonalId { get; set; }
    public Personal Personal { get; set; }
    public DateTime FechaAsignacion { get; set; }
}