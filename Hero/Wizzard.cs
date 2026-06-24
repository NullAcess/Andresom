using Andresom.Entities;
using Andresom.Heroes;
using Andresom.Weapones;

namespace Andresom.Wizzardes;

internal class Wizzard : Hero
{
    public Wizzard(Weapon weapon, string model, byte health, byte stamina, float physicalResist, float magicResist, float rangeResist) : base(weapon, model, health, stamina, physicalResist, magicResist, rangeResist)
    {

    }
}
