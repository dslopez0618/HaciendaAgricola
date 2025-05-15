namespace HaciendaAgricola.Models;

public class ProductoPedido
{
    public int PedidoId { get; set; }
    public Pedido Pedido { get; set; }
    public int ProductoTerminadoId { get; set; }
    public ProductoTerminado ProductoTerminado { get; set; }
    public double Cantidad { get; set; }
}