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
    public Archer(Weapon weapon, string model, byte health, byte stamina, float physicalResist, float magicResist, float rangeResist) : base(weapon, model, health, stamina, physicalResist, magicResist, rangeResist)
    {

    }
}
