using Microsoft.EntityFrameworkCore;

namespace MoviesList.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            :base(options)
        {
            
        }
        public DbSet<Movie> movie { get; set; }
    }
}
