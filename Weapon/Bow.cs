using Andresom.DamageTypes;
using Andresom.Weapones;

namespace Andresom.Bowes
{
    internal class Bow : Weapon
    {
        public Bow(byte requirementEnergy, DamageType damageType, byte damage) : base(requirementEnergy, damageType, damage)
        {

        }
    }
}