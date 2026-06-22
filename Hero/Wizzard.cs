using Andresom.Weapones;
using Andresom.Heroes;

namespace Andresom.Wizzard
{
    internal class Wizzard : Hero
    {
        public Wizzard(Weapon weapon, string model, byte health, byte stamina) : base(weapon, model, health, stamina)
        {
            this.Weapon = weapon;
            this.Model = model;
            this.Health = health;
            this.Stamina = stamina;
        }
    }
}
