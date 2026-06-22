using Andresom.Weapones;
using Andresom.Enemies;
using Andresom.Entities;

namespace Andresom.Heroes
{
    abstract internal class Hero : Entity
    {
        public Hero(Weapon weapon, string model, byte health, byte stamina) : base(weapon, model, health, stamina)
        {
            
        }

        public void Attack(Enemy enemy)
        {
            if (this.Stamina - 20 <= 0) this.Stamina = 0;
            else this.Stamina -= 20;
            // AttackedEnemy(enemy, DamageType, Damage);
        }
        public void RestoreStamina() => StaminaSettings(this);
    }
}
