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
    private const byte _health = 50;
    private const byte _stamina = 100;
    private const float _physicalResist = 0.8f;
    private const float _magicResist = 0.4f;
    private const float _rangeResist = 0.3f;

    public Skeleton(Weapon weapon, string model) : base(weapon, model, _health, _stamina, _physicalResist, _magicResist, _rangeResist)
    {

    }
}