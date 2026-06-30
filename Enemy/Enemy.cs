using Andresom.Archeres;
using Andresom.DamageTypes;
using Andresom.Entities;
using Andresom.Heroes;
using Andresom.Items;
using Andresom.Items.Weapones;
using Andresom.Knightes;
using Andresom.Wizzardes;

namespace Andresom.Enemies;

abstract internal class Enemy : Entity
{
    public Enemy(Weapon weapon, string model, byte health, byte stamina, float physicalResist, float magicResist, float rangeResist) : base(weapon, model, health, stamina, physicalResist, magicResist, rangeResist)
    {

    }

    public abstract Item DropItem();
}
