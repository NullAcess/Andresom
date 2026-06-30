using Andresom.DamageTypes;
using Andresom.Items.Weapones;

namespace Andresom.Items.Weapones.NastyClubs
{
    internal class NastyClub : Weapon
    {
        public const string _name = "NastyClub";
        private const byte _requirementEnergy = 30;
        private const DamageType _damageType = DamageType.PhysicalDamage;
        private const byte _damage = 75;
        public NastyClub() : base(_name, _requirementEnergy, _damageType, _damage)
        {

        }
    }
}