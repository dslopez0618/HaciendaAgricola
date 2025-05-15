namespace HaciendaAgricola.Models;

public class Insumo
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public string Lote { get; set; }
    public DateTime FechaCaducidad { get; set; }
    public decimal Costo { get; set; }
    public double Stock { get; set; }
    public List<InsumoLabor> LaboresUsadas { get; set; } = new List<InsumoLabor>();
}