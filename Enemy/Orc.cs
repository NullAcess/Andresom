using Andresom.Archeres;
using Andresom.DamageTypes;
using Andresom.Enemies;
using Andresom.Entities;
using Andresom.Knightes;
using Andresom.Weapones;
using Andresom.Wizzardes;

namespace Andresom.Orcses;

internal class Orc : Enemy
{
    public Orc(Weapon weapon, string model, byte health, byte stamina, float physicalResist, float magicResist, float rangeResist) : base(weapon, model, health, stamina, physicalResist, magicResist, rangeResist)
    {

    }
}