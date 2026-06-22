using Andresom.Weapones;
using Andresom.Heroes;

namespace Andresom.Archeres
{
    internal class Archer : Hero
    {
        public Archer(Weapon weapon, string model, byte health, byte stamina) : base(weapon, model, health, stamina)
        {
            this.Weapon = weapon;
            this.Model = model;
            this.Health = health;
            this.Stamina = stamina;
        }
    }
}
