using Andresom.DamageTypes;
using System.Runtime.CompilerServices;

namespace Andresom.Weapones
{
    internal class Weapon
    {
        public byte RequirementEnergy { get; private protected set; }
        public DamageType DamageTypes { get; private protected set; }
        public byte Damage { get; private protected set; }

        public Weapon(byte requirementEnergy, DamageType damageTypes, byte damage)
        {
            this.RequirementEnergy = requirementEnergy;
            this.DamageTypes = damageTypes;
            this.Damage = damage;
        }

        internal int SetDamage(int damage)
        {
            Random random = new Random();
            int critChance = random.Next(1, 101);
            if (critChance < 10)
                return damage *= 2;
            else
                return damage;
        }
    }
}
