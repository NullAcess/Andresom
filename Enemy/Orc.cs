using Andresom.Archeres;
using Andresom.DamageTypes;
using Andresom.Enemies;
using Andresom.Entities;
using Andresom.Knightes;
using Andresom.Weapones;
using Andresom.Wizzardes;

namespace Andresom.Orcses;

internal class Orc : Enemy
{
    public Orc(Weapon weapon, float physicalResist, float magicResist, float rangeResist, string model, byte health, byte stamina) : base(weapon, physicalResist, magicResist, rangeResist, model, health, stamina)
    {
        this.PhisycalResist = physicalResist;
        this.MagicResist = magicResist;
        this.RangeResist = rangeResist;
        this.Model = model;
        this.Health = health;
        this.Stamina = stamina;
    }

    private protected override void AttackedEnemyTarget(Entity target, Entity initiator)
    { 

        if (initiator is Knight && initiator.Weapon.DamageTypes == DamageType.PhysicalResist)
        {
            if (this.Health - initiator.Weapon.Damage * PhisycalResist <= 0) this.Health = 0;
            else this.Health -= (byte)(initiator.Weapon.Damage * PhisycalResist);
        }

        if (initiator is Wizzard && initiator.Weapon.DamageTypes == DamageType.MagicDamage)
        {
            if (this.Health - initiator.Weapon.Damage * MagicResist <= 0) this.Health = 0;
            else this.Health -= (byte)(initiator.Weapon.Damage * MagicResist);
        }

        if (initiator is Archer && initiator.Weapon.DamageTypes == DamageType.RangeDamage)
        {
            if (this.Health - initiator.Weapon.Damage * RangeResist <= 0) this.Health = 0;
            else this.Health -= (byte)(initiator.Weapon.Damage * RangeResist);
        }
    }
}
