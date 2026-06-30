using Andresom.DamageTypes;
using Andresom.Items.Weapones;

namespace Andresom.Items.Weapones.Swords
{
    internal class Sword : Weapon
    {
        public const string _name = "Sword";
        private const byte _requirementEnergy = 20;
        private const DamageType _damageType = DamageType.PhysicalDamage;
        private const byte _damage = 45;
        public Sword() : base(_name, _requirementEnergy, _damageType, _damage)
        {

        }
    }
}
