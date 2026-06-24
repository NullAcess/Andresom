using Andresom.DamageTypes;

namespace Andresom.Weapones
{
    internal class Weapon
    {
        public byte RequirementEnergy { get; private protected set; }
        public DamageType DamageTypes { get; private protected set; }
        private byte damage;
        public byte Damage
        {
            get 
            {
                Random random = new Random();
                int critChance = random.Next(1, 101);
                if (critChance < 10) return damage *= 2;
                else return damage;
            }
            set { damage = value; }
        }

        public Weapon(byte requirementEnergy, DamageType damageTypes, byte damage)
        {
            this.RequirementEnergy = requirementEnergy;
            this.DamageTypes = damageTypes;
            this.Damage = damage;
        }
    }
}
