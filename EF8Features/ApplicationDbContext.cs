using EF8Features.Entities;
using EF8Features.Models;
using Microsoft.EntityFrameworkCore;

namespace EF8Features;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer("Server=.;Database=TestEF8Db;MultipleActiveResultSets=True;Integrated Security=true;TrustServerCertificate=True");
    }


    public DbSet<Author> Authors { get; set; }

    public DbSet<Book> Books { get; set; }
}
