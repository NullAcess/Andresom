using Andresom.DamageTypes;

namespace Andresom.Weapones
{
    internal class Weapon
    {
        public byte RequirementEnergy { get; private protected set; } = 20;
        public DamageType DamageTypes { get; private protected set; }
        public byte Damage { get; private protected set; }

        public Weapon(byte requirementEnergy, DamageType damageTypes, byte damage)
        {
            this.RequirementEnergy = requirementEnergy;
            this.DamageTypes = damageTypes;
            this.Damage = damage;
        }
    }
}
