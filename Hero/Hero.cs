using Andresom.Weapones;
using Andresom.Enemies;
using Andresom.Entities;
using Andresom.Screenes;

namespace Andresom.Heroes;

abstract internal class Hero : Entity
{
    public Hero(Weapon weapon, string model, byte health, byte stamina, float physicalResist, float magicResist, float rangeResist) : base(weapon, model, health, stamina, physicalResist, magicResist, rangeResist)
    {
        
    }
}
