using Budget.Models;
using Microsoft.EntityFrameworkCore;

namespace Budget.Data
{
    public class BudgetContext : DbContext
    {

        public BudgetContext(DbContextOptions<BudgetContext> options) : base(options) { }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(t => t.Transactions)
                .WithOne(c => c.Category);
        }
    }
}
