using app.domain;
using Microsoft.EntityFrameworkCore;

namespace app.repository
{
    public class OnionDbContext : DbContext
    {
        public OnionDbContext(DbContextOptions<OnionDbContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
