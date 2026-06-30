using Andresom.DamageTypes;

namespace Andresom.Items.Weapones
{
    public class Weapon : Item
    {
        public new string Name { get; private protected set; } = "Not found a weapon";
        public byte RequirementEnergy { get; private protected set; }
        public DamageType DamageTypes { get; private protected set; }
        private byte damage;
        public byte Damage
        {
            get 
            {
                Random random = new Random();
                int critChance = random.Next(1, 101);
                if (critChance < 10) return (byte)(damage * 2);
                else return damage;
            }
            set { damage = value; }
        }

        public Weapon(string name, byte requirementEnergy, DamageType damageTypes, byte damage) : base(name)
        {
            RequirementEnergy = requirementEnergy;
            DamageTypes = damageTypes;
            Damage = damage;
        }
    }
}
