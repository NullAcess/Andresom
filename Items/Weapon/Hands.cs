using Andresom.DamageTypes;
using Andresom.Items.Weapones;

namespace Andresom.Items.Weapones.Hands
{
    internal class Hand : Weapon
    {
        public const string _name = "Hand";
        private const byte _requirementEnergy = 15;
        private const DamageType _damageType = DamageType.PhysicalDamage;
        private const byte _damage = 20;
        public Hand() : base(_name, _requirementEnergy, _damageType, _damage)
        {

        }
    }
}