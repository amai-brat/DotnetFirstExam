using Microsoft.EntityFrameworkCore;
using Shared;

namespace BusinessLogic.Model;

public class ApplicationContext : DbContext, IApplicationContext
{
    public DbSet<Monster> Monsters => Set<Monster>();
    
    public ApplicationContext(DbContextOptions options) : base(options)
    {}
}