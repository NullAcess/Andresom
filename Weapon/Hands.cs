using Andresom.DamageTypes;
using Andresom.Weapones;

namespace Andresom.Handes
{
    internal class Hand : Weapon
    {
        public Hand(byte requirementEnergy, DamageType damageType, byte damage) : base(requirementEnergy, damageType, damage)
        {

        }
    }
}