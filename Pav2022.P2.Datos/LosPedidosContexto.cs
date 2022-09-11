using Microsoft.EntityFrameworkCore;
using Pav2022.P2.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2022.P2.Datos
{
    public class LosPedidosContexto : DbContext, IUnidadDeTrabajoMarco
    {
        public LosPedidosContexto()
        {

        }

        public LosPedidosContexto(DbContextOptions<LosPedidosContexto> options)
        : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;

            optionsBuilder.UseSqlServer(@"Server=.;Database=TestPav;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Producto>()
                .ToTable("Productos")
                .Property(p => p.Descripcion)
                .HasMaxLength(150);

            modelBuilder
                .Entity<Pedido>()
                .ToTable("Pedidos");

            modelBuilder
                .Entity<LineaPedido>()
                .ToTable("LineasPedidos");
        }


        public void Confirmar()
        {
            base.SaveChanges();
        }

        public DbSet<T> CrearSet<T>() where T : class
        {
            return base.Set<T>();
        }

        public void Refrescar<T>(T item) where T : class
        {
            throw new NotImplementedException();
        }

        public void RevertirCambios()
        {
            throw new NotImplementedException();
        }

        public void SetModificado<T>(T item) where T : class
        {
            base.Entry(item).State = EntityState.Modified;
        }
    }
}
