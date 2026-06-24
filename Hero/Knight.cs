using Andresom.Entities;
using Andresom.Heroes;
using Andresom.Weapones;

namespace Andresom.Knightes;
internal class Knight : Hero
{
    public Knight(Weapon weapon, string model, byte health, byte stamina, float physicalResist, float magicResist, float rangeResist) : base(weapon, model, health, stamina, physicalResist, magicResist, rangeResist)
    {

    }
}

