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
    public Skeleton(Weapon weapon, string model, byte health, byte stamina, float physicalResist, float magicResist, float rangeResist) : base(weapon, model, health, stamina, physicalResist, magicResist, rangeResist)
    {

    }
}