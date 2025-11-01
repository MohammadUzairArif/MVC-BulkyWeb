using bulky_web.Models;
using Microsoft.EntityFrameworkCore;

namespace bulky_web.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Category> categories { get; set; }
    }
}
