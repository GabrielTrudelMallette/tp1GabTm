using Microsoft.EntityFrameworkCore;

namespace SiteOnepiece.Models.data
{
    public class OnepieceDbContext : DbContext
    {
        public DbSet<Enfant> enfants {  get; set; }
        public DbSet<Parent> parents { get; set; }

        public OnepieceDbContext(DbContextOptions<OnepieceDbContext> options) : base(options) 
        {
        }
    }
}
