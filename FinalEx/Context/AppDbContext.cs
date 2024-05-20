using FinalEx.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalEx.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
    }
}
