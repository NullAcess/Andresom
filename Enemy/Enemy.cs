using Andresom.Entities;
using Andresom.Orcses;
using Andresom.Weapones;
using Andresom.DamageTypes;
using Andresom.Heroes;

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
        if (this.Stamina - this.Weapon.RequirementEnergy < 0) RestoreStamina();
        else
        {
            this.Stamina -= this.Weapon.RequirementEnergy;
            AttackedUserTarget(user, this);
        }
    }
    public void RestoreStamina() => StaminaSettings(this);
}
