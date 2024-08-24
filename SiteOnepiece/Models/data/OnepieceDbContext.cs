using Microsoft.EntityFrameworkCore;

namespace SiteOnepiece.Models.data
{
    public class OnepieceDbContext : DbContext
    {
        public DbSet<Enfant> Enfants {  get; set; }
        public DbSet<Parent> Parents { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Générer des données de départ
            modelBuilder.GenerateData();
        }

        public OnepieceDbContext(DbContextOptions<OnepieceDbContext> options) : base(options) 
        {
        }
    }
}
