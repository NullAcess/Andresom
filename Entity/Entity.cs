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
        PhysicalResist = physicalResist;
        MagicResist = magicResist;
        RangeResist = rangeResist;
        Weapon = weapon;
        Model = model;
        Health = health;
        Stamina = stamina;
    }

    public bool AttackTarget(Entity target)
    {
        float currentResist = 0;

        if (Stamina < Weapon.RequirementEnergy) return false;
        else Stamina -= Weapon.RequirementEnergy;

        switch (Weapon.DamageTypes)
        {
            case DamageType.PhysicalDamage: currentResist = target.PhysicalResist; break;
            case DamageType.MagicDamage: currentResist = target.MagicResist; break;
            case DamageType.RangeDamage: currentResist = target.RangeResist; break;
        }

        byte baseDamage = Weapon.Damage;
        byte finalDamage = (byte)(baseDamage * currentResist);

        System.Console.WriteLine($"\n[DEBUG] {this.GetType().Name} attacks {target.GetType().Name}!");
        System.Console.WriteLine($"[DEBUG] Weapon Damage: {baseDamage} | Target Resist: {currentResist} | Calculated Final Damage: {finalDamage}");
        
        if (target.Health - finalDamage <= 0) target.Health = 0;
        else target.Health -= finalDamage;

        System.Console.WriteLine($"[DEBUG] Target Health: {target.Health}");
        System.Threading.Thread.Sleep(2000);

        return true;
    }

    public void RestoreStamina(bool isNewRound)
    {
        if (isNewRound == true) { Stamina = 100; return; }
        if (Stamina + 10 >= 100) Stamina = 100;
        else Stamina += 10;
    }
}