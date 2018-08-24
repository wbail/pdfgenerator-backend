using Microsoft.EntityFrameworkCore;

namespace PdfGenerator.Models
{
    public class PdfGeneratorContext : DbContext
    {
        public PdfGeneratorContext(DbContextOptions<PdfGeneratorContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<BillingUser> BillingUsers { get; set; }
    }
}
