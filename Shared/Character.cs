using System.ComponentModel.DataAnnotations;

namespace Shared;

public class Character : ICreature
{
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Hit points need to be more than 0")]
    public int HitPoints { get; set; }
    
    [Required]
    [Range(-5, 5, ErrorMessage = "Attack modifier is in range [-5, 5]")]
    public int AttackModifier { get; set; }
    
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "At least 1 attack per round")]
    public int AttackPerRound { get; set; }
    
    [Required]
    [RegularExpression(@"\d+d\d+", ErrorMessage = "Damage input is like 1d6")]
    public string Damage { get; set; } = null!;

    [Required]
    public int DamageModifier { get; set; }
    
    [Required]
    public int Weapon { get; set; }
    
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "AC is more than 0")]
    public int ArmorClass { get; set; }
}