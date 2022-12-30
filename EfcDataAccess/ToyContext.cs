using Domain;
using Microsoft.EntityFrameworkCore;
namespace EfcDataAccess;

public class ToyContext:DbContext
{
    public DbSet<Child> Children { get; set; }
    public DbSet<Toy> Toys { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = ../EfcDataAccess/Toy.db");
    }
}