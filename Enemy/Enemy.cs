using Andresom.Archeres;
using Andresom.DamageTypes;
using Andresom.Entities;
using Andresom.Heroes;
using Andresom.Knightes;
using Andresom.Weapones;
using Andresom.Wizzardes;

namespace Andresom.Enemies;

abstract internal class Enemy : Entity
{
    public float PhisycalResist { get; private protected set; } = 0;
    public float MagicResist { get; private protected set; } = 0;
    public float RangeResist { get; private protected set; } = 0;

    public Enemy(Weapon weapon, float physicalResist, float magicResist, float rangeResist, string model, byte health, byte stamina) : base(weapon, model, health, stamina)
    {
        PhisycalResist = physicalResist;
        MagicResist = magicResist;
        RangeResist = rangeResist;
    }
    public void AttackUser(Hero user)
    {

        if (this.Stamina - this.Weapon.RequirementEnergy < 0) RestoreEnemyStamina();
        else
        {
            this.Stamina -= this.Weapon.RequirementEnergy;
            AttackedUserTarget(user, this);
        }
    }
    public void RestoreEnemyStamina() => StaminaSettings(this);

    private protected override void AttackedEnemyTarget(Entity target, Entity initiator)
    {
        if (initiator is Knight && initiator.Weapon.DamageTypes == DamageType.PhysicalResist)
        {
            if (this.Health - Weapon.SetDamage(initiator.Weapon.Damage) * PhisycalResist <= 0) this.Health = 0;
            else this.Health -= (byte)(Weapon.SetDamage(initiator.Weapon.Damage) * PhisycalResist);
        }

        if (initiator is Wizzard && initiator.Weapon.DamageTypes == DamageType.MagicDamage)
        {
            if (this.Health - Weapon.SetDamage(initiator.Weapon.Damage) * MagicResist <= 0) this.Health = 0;
            else this.Health -= (byte)(Weapon.SetDamage(initiator.Weapon.Damage) * MagicResist);
        }

        if (initiator is Archer && initiator.Weapon.DamageTypes == DamageType.RangeDamage)
        {
            if (this.Health - Weapon.SetDamage(initiator.Weapon.Damage) * RangeResist <= 0) this.Health = 0;
            else this.Health -= (byte)(Weapon.SetDamage(initiator.Weapon.Damage) * RangeResist);
        }
    }
}
