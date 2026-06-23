using Andresom.Archeres;
using Andresom.DamageTypes;
using Andresom.Enemies;
using Andresom.Entities;
using Andresom.Knightes;
using Andresom.Weapones;
using Andresom.Wizzardes;

namespace Andresom.Skeletones;

internal class Skeleton : Enemy
{
    public Skeleton(Weapon weapon, float physicalResist, float magicResist, float rangeResist, string model, byte health, byte stamina) : base(weapon, physicalResist, magicResist, rangeResist, model, health, stamina)
    {
        this.PhisycalResist = physicalResist;
        this.MagicResist = magicResist;
        this.RangeResist = rangeResist;
        this.Model = model;
        this.Health = health;
        this.Stamina = stamina;
    }
}
