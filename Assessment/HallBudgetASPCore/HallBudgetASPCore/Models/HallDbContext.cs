using Microsoft.EntityFrameworkCore;

namespace HallBudgetASPCore.Models
{
    public class HallDbContext : DbContext
    {
        public HallDbContext(DbContextOptions opts) : base(opts)
        { 

        }
        public DbSet<HallDetails> hall { get; set; }
        
    }
}
