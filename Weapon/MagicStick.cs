using Andresom.DamageTypes;
using Andresom.Weapones;

namespace Andresom.MagicStickes
{
    internal class MagicStick : Weapon
    {
        private const byte _requirementEnergy = 15;
        private const DamageType _damageType = DamageType.MagicDamage;
        private const byte _damage = 25;
        public MagicStick() : base(_requirementEnergy, _damageType, _damage)
        {

        }
    }
}