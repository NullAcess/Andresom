using Andresom.DamageTypes;
using Andresom.Entities;
using Andresom.Heroes;
using Andresom.Knightes;
using Andresom.Orcses;
using Andresom.Weapones;
using Andresom.Wizzardes;

namespace Andresom.Archeres;

internal class Archer : Hero
{
    public Archer(Weapon weapon, string model, byte health, byte stamina, float physicalResist) : base(weapon, model, health, stamina, physicalResist)
    {
        this.PhysicalResist = physicalResist;
        this.Weapon = weapon;
        this.Model = model;
        this.Health = health;
        this.Stamina = stamina;
    }

    private protected override void Attacked_User_Target(Entity target, Entity initiator)
    {
        if (this.Health - initiator.Weapon.Damage * PhysicalResist <= 0) Health = 0;
        else this.Health -= (byte)(initiator.Weapon.Damage * PhysicalResist);
    }
}
