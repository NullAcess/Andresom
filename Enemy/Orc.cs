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
    private const byte _health = 250;
    private const byte _stamina = 100;
    private const float _physicalResist = 0.5f;
    private const float _magicResist = 0.9f;
    private const float _rangeResist = 0.8f;

    public Orc(Weapon weapon, string model) : base(weapon, model, _health, _stamina, _physicalResist, _magicResist, _rangeResist)
    {

    }
}