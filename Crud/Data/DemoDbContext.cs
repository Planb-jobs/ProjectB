using Crud.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Crud.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
    }
}
