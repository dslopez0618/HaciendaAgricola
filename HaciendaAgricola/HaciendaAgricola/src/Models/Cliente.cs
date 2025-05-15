namespace HaciendaAgricola.Models;

public class Cliente
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Contacto { get; set; }
    public string Preferencias { get; set; }
    public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
}