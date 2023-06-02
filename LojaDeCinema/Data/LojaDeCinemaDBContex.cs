using LojaDeCinema.Data.Map;
using LojaDeCinema.Modelos;
using Microsoft.EntityFrameworkCore;

namespace LojaDeCinema.Data
{
    public class LojaDeCinemaDBContex : DbContext
    {
        public LojaDeCinemaDBContex(DbContextOptions<LojaDeCinemaDBContex> options) : base(options) { }

        public DbSet<Bilhete> Bilhetes { get; set; }
        public DbSet<ItemAlimentar> itemsAlimentar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfiguration(new BilheteMap());
            modelBuilder.ApplyConfiguration(new ItemAlimentarMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
