using Shared;

namespace BusinessLogic.Services;

public class Combat : ICombat
{
    public Result GetResult(Character character, Monster monster)
    {
        var result = new Result
        {
            Logs = []
        };
        
        while (true)
        {
            if (character.HitPoints > 0)
            {
                var log = GetCombatLog(character, monster);
                result.Logs.Add(log);
            }
            else
            {
                result.WinnerName = monster.Name;
                break;
            }

            if (monster.HitPoints > 0)
            {
                var log = GetCombatLog(monster, character);
                result.Logs.Add(log);
            }
            else
            {
                result.WinnerName = character.Name;
                break;
            }
        }

        return result;
    }

    private CombatLog GetCombatLog(ICreature attacker, ICreature attacked)
    {
        var log = new CombatLog
        {
            AttackerName = attacker.Name,
            AttackedName = attacked.Name,
            AttackModifier = attacker.AttackModifier,
            DamageModifier = attacker.DamageModifier,
            Weapon = attacker.Weapon,
            AttackedArmorClass = attacked.ArmorClass,
            AttackPerRound = attacker.AttackPerRound,
            AttackDiceRolls = new int[attacker.AttackPerRound],
            HitTypes = new HitType[attacker.AttackPerRound],
            Damages = new int[attacker.AttackPerRound],
            DamageRolls = new int[attacker.AttackPerRound]
        };
                
        for (var i = 0; i < attacker.AttackPerRound; i++)
        {
            var attackDiceRoll = Random.Shared.Next(1, 20);
            log.AttackDiceRolls[i] = attackDiceRoll;
            if (attackDiceRoll == 1)
            {
                log.HitTypes[i] = HitType.CriticalMiss;
            }
            else if (attackDiceRoll == 20)
            {
                log.HitTypes[i] = HitType.CriticalHit;
                var splitted = attacker.Damage.Split('d'); 
                log.DamageRolls[i] = GetSumOfDamageRolls(int.Parse(splitted[0]), int.Parse(splitted[1]));
                log.Damages[i] = 2 * (attacker.Weapon + attacker.DamageModifier + log.DamageRolls[i]);
                attacked.HitPoints -= log.Damages[i];
            }
            else
            {
                if (attackDiceRoll + attacker.AttackModifier + attacker.Weapon >= attacked.ArmorClass)
                {
                    log.HitTypes[i] = HitType.Hit;
                    var splitted = attacker.Damage.Split('d');
                    log.DamageRolls[i] = GetSumOfDamageRolls(int.Parse(splitted[0]), int.Parse(splitted[1]));
                    log.Damages[i] = attacker.Weapon + attacker.DamageModifier + log.DamageRolls[i];
                    attacked.HitPoints -= log.Damages[i];
                }
                else
                {
                    log.HitTypes[i] = HitType.Miss;
                }
            }
            log.AttackedHitPoints = attacked.HitPoints;
        }

        return log;
    }

    private int GetSumOfDamageRolls(int count, int diceFaces)
    {
        var res = 0;
        for (var i = 0; i < count; i++)
        {
            res += Random.Shared.Next(1, diceFaces + 1);
        }

        return res;
    }
}