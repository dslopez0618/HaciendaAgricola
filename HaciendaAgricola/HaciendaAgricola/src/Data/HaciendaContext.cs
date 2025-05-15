using HaciendaAgricola.Models;
using Microsoft.EntityFrameworkCore;

namespace HaciendaAgricola.Data
{
    public class HaciendaContext : DbContext
    {
        public DbSet<Parcela> Parcelas { get; set; }
        public DbSet<Cultivo> Cultivos { get; set; }
        public DbSet<LaborAgricola> LaboresAgricolas { get; set; }
        public DbSet<Insumo> Insumos { get; set; }
        public DbSet<InsumoLabor> InsumosLabores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ProductoTerminado> ProductosTerminados { get; set; }
        public DbSet<ProductoPedido> ProductosPedidos { get; set; }
        public DbSet<Personal> Personal { get; set; }
        public DbSet<PersonalLabor> PersonalLabores { get; set; }

        public HaciendaContext(DbContextOptions<HaciendaContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InsumoLabor>()
                .HasKey(il => new { il.LaborAgricolaId, il.InsumoId });

            modelBuilder.Entity<InsumoLabor>()
                .HasOne(il => il.LaborAgricola)
                .WithMany(l => l.InsumosUsados)
                .HasForeignKey(il => il.LaborAgricolaId);

            modelBuilder.Entity<InsumoLabor>()
                .HasOne(il => il.Insumo)
                .WithMany(i => i.LaboresUsadas)
                .HasForeignKey(il => il.InsumoId);

            modelBuilder.Entity<ProductoPedido>()
                .HasKey(pp => new { pp.PedidoId, pp.ProductoTerminadoId });

            modelBuilder.Entity<ProductoPedido>()
                .HasOne(pp => pp.Pedido)
                .WithMany(p => p.Productos)
                .HasForeignKey(pp => pp.PedidoId);

            modelBuilder.Entity<ProductoPedido>()
                .HasOne(pp => pp.ProductoTerminado)
                .WithMany(pt => pt.Pedidos)
                .HasForeignKey(pp => pp.ProductoTerminadoId);

            modelBuilder.Entity<PersonalLabor>()
                .HasKey(pl => new { pl.LaborAgricolaId, pl.PersonalId });

            modelBuilder.Entity<PersonalLabor>()
                .HasOne(pl => pl.LaborAgricola)
                .WithMany(l => l.PersonalAsignado)
                .HasForeignKey(pl => pl.LaborAgricolaId);

            modelBuilder.Entity<PersonalLabor>()
                .HasOne(pl => pl.Personal)
                .WithMany(p => p.LaboresAsignadas)
                .HasForeignKey(pl => pl.PersonalId);

            modelBuilder.Entity<Cultivo>()
                .HasOne(c => c.Parcela)
                .WithMany(p => p.Cultivos)
                .HasForeignKey(c => c.ParcelaId);

            modelBuilder.Entity<LaborAgricola>()
                .HasOne(l => l.Cultivo)
                .WithMany(c => c.Labores)
                .HasForeignKey(l => l.CultivoId);

            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(p => p.ClienteId);
        }
    }
}