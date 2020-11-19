using System;
using blazor_mysql2.Shared;
using Microsoft.EntityFrameworkCore;

namespace blazor_mysql2.Server
{
     public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Categoria> Categories { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetalhePedido> DetalhePedido { get; set; }

        public DbSet<UserDetails> UserDetails { get; set; }
        DateTime data = new DateTime(1999,03,31);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetalhePedido>()
                .HasKey(p => new {p.PedidoId, p.ProductId});

            modelBuilder.Entity<DetalhePedido>()
                .HasOne(pd => pd.Pedido)
                .WithMany(pr => pr.DetalhePedidos)
                .HasForeignKey(pd => pd.PedidoId);
            
            modelBuilder.Entity<DetalhePedido>()
                .HasOne(pd => pd.Produto)
                .WithMany(pr => pr.DetalhePedidos)
                .HasForeignKey(pd => pd.ProductId);
       
            modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId =1,
                Title = "Sr",
                FirstName = "Luis",
                MiddleName = "Guilherme",
                LastName = "Sobral",
                DateOfBirth = data,
                Email = "sobrazinhoOchave@gmail.com",
                Password = "123456",
                ConfirmPassword = "123456",
                AcceptTerms = true
            }
            );


        }                
    }
    
}