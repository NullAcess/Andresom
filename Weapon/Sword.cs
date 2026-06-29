using Andresom.DamageTypes;
using Andresom.Weapones;
using SixLabors.ImageSharp.Processing;

namespace Andresom.Swordes
{
    internal class Sword : Weapon
    {
        private const byte _requirementEnergy = 20;
        private const DamageType _damageType = DamageType.PhysicalDamage;
        private const byte _damage = 45;
        public Sword() : base(_requirementEnergy, _damageType, _damage)
        {

        }
    }
}
