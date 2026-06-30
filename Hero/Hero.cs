using Andresom.Enemies;
using Andresom.Entities;
using Andresom.Items.Inventoryes;
using Andresom.Items.Weapones;
using Andresom.Screenes;

namespace Andresom.Heroes;

abstract internal class Hero : Entity
{
    public Inventory PlayerInventory { get; private set; } = new Inventory();
    public Hero(Weapon weapon, string model, byte health, byte stamina, float physicalResist, float magicResist, float rangeResist) : base(weapon, model, health, stamina, physicalResist, magicResist, rangeResist)
    {
        
    }
}