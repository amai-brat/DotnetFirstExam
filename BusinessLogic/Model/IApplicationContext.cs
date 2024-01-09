using Microsoft.EntityFrameworkCore;
using Shared;

namespace BusinessLogic.Model;

public interface IApplicationContext
{
    public DbSet<Monster> Monsters { get; }
}