using Andresom.DamageTypes;
using Andresom.Enemies;
using Andresom.Weapones;
using Andresom.Heroes;
using Andresom.Orcses;
using Andresom.Skeletones;
using Andresom.Knightes;
using Andresom.Wizzardes;
using Andresom.Archeres;

namespace Andresom.Entities;

abstract internal class Entity
{
    public float PhysicalResist { get; private protected set; }
    public float MagicResist { get; private protected set; }
    public float RangeResist { get; private protected set; }
    public string Model { get; private protected set; } = "Model not found";
    public Weapon Weapon { get; private protected set; }
    public byte Health { get; private protected set; }
    public byte Stamina { get; private protected set; }

    public Entity(Weapon weapon, string model, byte health, byte stamina, float physicalResist, float magicResist, float rangeResist)
    {
        Weapon = weapon;
        Model = model;
        Health = health;
        Stamina = stamina;
    }

    public bool AttackTarget(Entity target)
    {
        if (Stamina - Weapon.RequirementEnergy < 0) return false;

        if (Weapon.DamageTypes == DamageType.PhysicalDamage)
            target.Health -= (byte)(Weapon.Damage * target.PhysicalResist);
        else if(Weapon.DamageTypes == DamageType.MagicDamage)
            target.Health -= (byte)(Weapon.Damage * target.MagicResist);
        else if(Weapon.DamageTypes == DamageType.RangeDamage)
            target.Health -= (byte)(Weapon.Damage * target.RangeResist);

        return true;
    }

    public void RestoreStamina()
    {
        if (Stamina + 10 >= 100) Stamina = 100;
        else Stamina += 10;
    }
}