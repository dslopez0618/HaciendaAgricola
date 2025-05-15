namespace HaciendaAgricola.Models;

public class ProductoTerminado
{
    public int Id { get; set; }
    public string Tipo { get; set; }
    public string Variedad { get; set; }
    public string Calidad { get; set; }
    public string Lote { get; set; }
    public double Stock { get; set; }
    public List<ProductoPedido> Pedidos { get; set; } = new List<ProductoPedido>();
}