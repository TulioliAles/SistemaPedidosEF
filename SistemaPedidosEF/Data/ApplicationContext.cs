using Microsoft.EntityFrameworkCore;
using SistemaPedidosEF.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPedidosEF.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\ServidorLocal; Database=SistemaPedidoEF; Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }
    }
}
