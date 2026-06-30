using Andresom.Archeres;
using Andresom.DamageTypes;
using Andresom.Enemies;
using Andresom.Entities;
using Andresom.Items;
using Andresom.Items.Weapones;
using Andresom.Knightes;
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

    public override Item DropItem()
    {
        Random random = new Random();
        int dropChance = random.Next(1, 101);
        if (dropChance < 2) return Weapon;
        else return null;
    }
}