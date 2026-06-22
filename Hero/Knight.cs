using Andresom.Entities;
using Andresom.Heroes;
using Andresom.Weapones;

namespace Andresom.Knightes;
    internal class Knight : Hero
    {
        public Knight(Weapon weapon, string model, byte health, byte stamina, float physicalResist) : base(weapon, model, health, stamina, physicalResist)
        {
            this.PhysicalResist = physicalResist;
            this.Weapon = weapon;
            this.Model = model;
            this.Health = health;
            this.Stamina = stamina;
        }

        private protected override void AttackedUserTarget(Entity target, Entity initiator)
        {
            if (this.Health - initiator.Weapon.Damage * PhysicalResist <= 0) Health = 0;
            else this.Health -= (byte)(initiator.Weapon.Damage * PhysicalResist);
        }
    }
