using Andresom.DamageTypes;
using Andresom.Weapones;

namespace Andresom.MagicStickes
{
    internal class MagicStick : Weapon
    {
        public MagicStick(byte requirementEnergy, DamageType damageType, byte damage) : base(requirementEnergy, damageType, damage)
        {

        }
    }
}