using Andresom.Entities;
using Andresom.Heroes;
using Andresom.Items.Weapones;

namespace Andresom.Knightes;
internal class Knight : Hero
{
    private const byte _health = 250;
    private const byte _stamina = 100;
    private const float _physicalResist = 0.3f;
    private const float _magicResist = 0.7f;
    private const float _rangeResist = 0.5f;

    public Knight(Weapon weapon, string model) : base(weapon, model, _health, _stamina, _physicalResist, _magicResist, _rangeResist)
    {

    }
}

