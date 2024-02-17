using Microsoft.EntityFrameworkCore;

namespace Mission6_HaydenEnloe.Models
{
    public class EnterMovieContext : DbContext
    {
        public EnterMovieContext(DbContextOptions<EnterMovieContext> options) : base(options) 
        { 
        }
        public DbSet<EnterMovie> Applications { get; set; }
    }
}
