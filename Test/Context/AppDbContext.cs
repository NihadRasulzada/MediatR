using Microsoft.EntityFrameworkCore;
using Test.Entities;

namespace Test.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
