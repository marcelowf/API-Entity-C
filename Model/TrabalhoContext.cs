using Microsoft.EntityFrameworkCore;

namespace Trabalho
{
    public class TrabalhoContext : DbContext
    {
        public DbSet<Hotel> Hoteis {get; set;} = null!;
        public DbSet<Filial> Filiais {get; set;} = null!;
        public DbSet<Quarto> Quartos {get; set;} = null!;
        public DbSet<Funcionario> Funcionarios {get; set;} = null!;
        public DbSet<Cliente> Clientes {get; set;} = null!;
        public DbSet<ContatosCliente> ContatosClientes {get; set;} = null!;
        public DbSet<Checkin> Checkins {get; set;} = null!;
        public DbSet<CheckOut> CheckOuts {get; set;} = null!;
        public DbSet<Reserva> Reservas {get; set;} = null!;
        public DbSet<Restaurante> Restaurantes {get; set;} = null!;
        public DbSet<Frigobar> Frigobars {get; set;} = null!;
        public DbSet<Lavanderia> Lavanderias {get; set;} = null!;
        public DbSet<ConsumoRestaurante> ConsumoRestaurantes {get; set;} = null!;
        public DbSet<ConsumoFrigobar> ConsumoFrigobars {get; set;} = null!;
        public DbSet<ConsumoLavanderia> ConsumoLavanderias {get; set;} = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=TrabalhoFinal;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }
    }
}