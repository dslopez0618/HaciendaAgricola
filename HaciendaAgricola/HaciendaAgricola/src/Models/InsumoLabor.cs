namespace HaciendaAgricola.Models;

public class InsumoLabor
{
    public int LaborAgricolaId { get; set; }
    public LaborAgricola LaborAgricola { get; set; }
    public int InsumoId { get; set; }
    public Insumo Insumo { get; set; }
    public double CantidadUsada { get; set; }
}