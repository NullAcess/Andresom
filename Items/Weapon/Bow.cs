using Andresom.DamageTypes;
using Andresom.Items.Weapones;

namespace Andresom.Items.Weapones.Bowes
{
    internal class Bow : Weapon
    {
        public const string _name = "Bow";
        private const byte _requirementEnergy = 10;
        private const DamageType _damageType = DamageType.RangeDamage;
        private const byte _damage = 15;
        public Bow() : base(_name, _requirementEnergy, _damageType, _damage)
        {

        }
    }
}