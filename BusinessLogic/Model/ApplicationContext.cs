using Microsoft.EntityFrameworkCore;
using Shared;

namespace BusinessLogic.Model;

public class ApplicationContext : DbContext, IApplicationContext
{
    public DbSet<Monster> Monsters => Set<Monster>();
    public async Task<Monster> GetRandomMonsterAsync()
    {
        var count = await Monsters.CountAsync();
        return await Monsters.ElementAtAsync(Random.Shared.Next(0, count));
    }

    public ApplicationContext(DbContextOptions options) : base(options)
    {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var imp = new Monster
        {
            Id = 1,
            Name = "Imp",
            HitPoints = 10,
            AttackModifier = -2,
            AttackPerRound = 1,
            Damage = "3d4",
            DamageModifier = 2,
            Weapon = 1,
            ArmorClass = 13
        };

        var kysh = new Monster
        {
            Id = 2,
            Name = "Kysh",
            HitPoints = 27,
            AttackModifier = 2,
            AttackPerRound = 1,
            Damage = "5d8",
            DamageModifier = 2,
            Weapon = 1,
            ArmorClass = 13
        };

        var creeper = new Monster
        {
            Id = 3,
            Name = "Creeper",
            HitPoints = 19,
            AttackModifier = 0,
            AttackPerRound = 1,
            Damage = "3d8",
            DamageModifier = 2,
            Weapon = 0,
            ArmorClass = 12
        };

        modelBuilder.Entity<Monster>().HasData(imp, kysh, creeper);
    }
}