using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext:DbContext   // inherit from dbcontext cls 
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {}

        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; } 
    }
}
