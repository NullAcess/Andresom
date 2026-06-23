using Andresom.Weapones;
using Andresom.Enemies;
using Andresom.Entities;
using Andresom.Screenes;

namespace Andresom.Heroes;

abstract internal class Hero : Entity
{
    public float PhysicalResist { get; private protected set; } = 0;
    public Hero(Weapon weapon, string model, byte health, byte stamina, float physicalResist) : base(weapon, model, health, stamina)
    {
        
    }

    public bool AttackEnemy(Enemy enemy)
    {
        if (this.Stamina - this.Weapon.RequirementEnergy < 0) return false;
        else 
        { 
            this.Stamina -= this.Weapon.RequirementEnergy;
            AttackedEnemyTarget(enemy, this); 
            return true; 
        }
    }
    public void RestoreUserStamina(bool isNewWave = false) => StaminaSettings(this, isNewWave);

    private protected override void AttackedUserTarget(Entity target, Entity initiator)
    {
        if (this.Health - Weapon.SetDamage(initiator.Weapon.Damage) * PhysicalResist <= 0) Health = 0;
        else this.Health -= (byte)(Weapon.SetDamage(initiator.Weapon.Damage) * PhysicalResist);
    }
}
