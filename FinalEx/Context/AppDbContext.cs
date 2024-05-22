using FinalEx.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalEx.Context
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<FinalEx.Models.Employee> Employee { get; set; } = default!;
        public DbSet<FinalEx.Models.Post> Post { get; set; } = default!;
    }
}
