using System.ComponentModel.DataAnnotations;

namespace Shared;

public class Monster : ICreature
{
    public int Id { get; set; }
    [Required] public int HitPoints { get; set; }
    [Required] public int AttackModifier { get; set; }
    [Required] public int AttackPerRound { get; set; }
    [Required] public string Damage { get; set; } = null!;
    [Required] public int DamageModifier { get; set; }
    [Required] public int Weapon { get; set; }
    [Required] public int ArmorClass { get; set; }
}