using Andresom.DamageTypes;
using Andresom.Weapones;

namespace Andresom.Bowes
{
    internal class Bow : Weapon
    {
        private const byte _requirementEnergy = 10;
        private const DamageType _damageType = DamageType.RangeDamage;
        private const byte _damage = 15;
        public Bow() : base(_requirementEnergy, _damageType, _damage)
        {

        }
    }
}