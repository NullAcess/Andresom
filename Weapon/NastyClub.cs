using Andresom.DamageTypes;
using Andresom.Weapones;

namespace Andresom.NastyClubes
{
    internal class NastyClub : Weapon
    {
        private const byte _requirementEnergy = 30;
        private const DamageType _damageType = DamageType.PhysicalDamage;
        private const byte _damage = 75;
        public NastyClub() : base(_requirementEnergy, _damageType, _damage)
        {

        }
    }
}