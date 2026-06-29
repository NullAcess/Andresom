using Andresom.DamageTypes;
using Andresom.Weapones;

namespace Andresom.Handes
{
    internal class Hand : Weapon
    {
        private const byte _requirementEnergy = 15;
        private const DamageType _damageType = DamageType.PhysicalDamage;
        private const byte _damage = 20;
        public Hand() : base(_requirementEnergy, _damageType, _damage)
        {

        }
    }
}