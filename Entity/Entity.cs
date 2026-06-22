using Andresom.DamageTypes;
using Andresom.Enemies;
using Andresom.Orcs;
using Andresom.Weapones;

namespace Andresom.Entities
{
    abstract internal class Entity
    {
        public string Model { get; private protected set; } = "Model not found";
        public Weapon Weapon { get; protected set; }
        public byte Health { get; private protected set; } = 100;
        public byte Stamina { get; private protected set; } = 100;

        public Entity(Weapon weapon, string model, byte health, byte stamina)
        {
            this.Weapon = weapon;
            this.Model = model;
            this.Health = health;
            this.Stamina = stamina;
        }

        private protected void AttackedEnemy(Enemy target, DamageType damageType, byte damage)
        {
            if (target is Orc && damageType == DamageType.PhysicalDamage)
            {
                damage = (byte)(damage * target.PhisycalResist);
            }

            else if (target is Orc && damageType == DamageType.MagicDamage)
            {
                damage = (byte)(damage * target.MagicResist);
            }
            else if(target is Orc && damageType == DamageType.RangeDamage)
            {
                damage = (byte)(damage * target.RangeResist);
            }

            if(target.Health - damage < 0) target.Health = 0;
            else target.Health -= damage;
        }

        private protected void StaminaSettings(Entity target)
        {
            if(target.Stamina + 10 >= 100) target.Stamina = 100;
            else target.Stamina += 10;
        }
    }
}
