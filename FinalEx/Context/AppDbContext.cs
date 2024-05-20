using Microsoft.EntityFrameworkCore;

namespace FinalEx.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
