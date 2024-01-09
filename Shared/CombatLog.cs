namespace Shared;

public class CombatLog
{
    public string AttackerName { get; set; } = null!;
    public string AttackedName { get; set; } = null!;

    public int AttackModifier { get; set; }
    public int DamageModifier { get; set; }
    public int Weapon { get; set; }
    
    public int AttackedArmorClass { get; set; }
    public int AttackedHitPoints { get; set; }
    
    public int AttackPerRound { get; set; }
    public int[] AttackDiceRolls { get; set; } = null!;
    public HitType[] HitTypes { get; set; } = null!;
    public int[] Damages { get; set; } = null!;
}