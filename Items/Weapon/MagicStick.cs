using Andresom.DamageTypes;
using Andresom.Items.Weapones;

namespace Andresom.Items.Weapones.MagicStickes
{
    internal class MagicStick : Weapon
    {
        public const string _name = "Magic Stick";
        private const byte _requirementEnergy = 15;
        private const DamageType _damageType = DamageType.MagicDamage;
        private const byte _damage = 25;
        public MagicStick() : base(_name, _requirementEnergy, _damageType, _damage)
        {

        }
    }
}