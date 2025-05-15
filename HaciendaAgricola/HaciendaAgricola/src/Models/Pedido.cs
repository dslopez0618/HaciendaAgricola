namespace HaciendaAgricola.Models;

public class Pedido
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public string Estado { get; set; }
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }
    public List<ProductoPedido> Productos { get; set; } = new List<ProductoPedido>();
}