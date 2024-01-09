using System.ComponentModel.DataAnnotations;

namespace Shared;

public class Character : ICreature
{
    [Required]
    public string Name { get; set; } = null!;

    [Required]
    [Range(1, 200, ErrorMessage = "Hit points need to be more than 0 and less than 200")]
    public int HitPoints { get; set; }
    
    [Required]
    [Range(-5, 5, ErrorMessage = "Attack modifier is in range [-5, 5]")]
    public int AttackModifier { get; set; }
    
    [Required]
    [Range(1, 5, ErrorMessage = "At least 1 attack per round, at most 5")]
    public int AttackPerRound { get; set; }
    
    [Required]
    [RegularExpression(@"\d+d\d+", ErrorMessage = "Damage input is like 1d6")]
    public string Damage { get; set; } = null!;

    [Required]
    [Range(-5, 5, ErrorMessage = "Damage modifier is in range [-5, 5]")]
    public int DamageModifier { get; set; }
    
    [Required]
    [Range(0, 5, ErrorMessage = "Weapon modifier is in range [0, 5]")]
    public int Weapon { get; set; }
    
    [Required]
    [Range(1, 50, ErrorMessage = "AC is more than 0 and less than 50")]
    public int ArmorClass { get; set; }
}