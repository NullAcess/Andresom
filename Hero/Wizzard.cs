using Andresom.Entities;
using Andresom.Heroes;
using Andresom.Weapones;

namespace Andresom.Wizzardes;

internal class Wizzard : Hero
{
    private const byte _health = 150;
    private const byte _stamina = 100;
    private const float _physicalResist = 0.8f;
    private const float _magicResist = 0.3f;
    private const float _rangeResist = 0.5f;

    public Wizzard(Weapon weapon, string model) : base(weapon, model, _health, _stamina, _physicalResist, _magicResist, _rangeResist)
    {

    }
}
