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
    private const byte _health = 200;
    private const byte _stamina = 100;
    private const float _physicalResist = 0.7f;
    private const float _magicResist = 0.5f;
    private const float _rangeResist = 0.3f;

    public Archer(Weapon weapon, string model) : base(weapon, model, _health, _stamina, _physicalResist, _magicResist, _rangeResist)
    {

    }
}
