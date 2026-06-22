using Andresom.Enemies;

namespace Andresom.Orcs
{
    internal class Orc : Enemy
    {
        public Orc(float phisycalResist, float magicResist, float rangeResist, string model, byte health, byte stamina) : base(phisycalResist, magicResist, rangeResist, model, health, stamina)
        {
            this.PhisycalResist = phisycalResist;
            this.MagicResist = magicResist;
            this.RangeResist = rangeResist;
            this.Model = model;
            this.Health = health;
            this.Stamina = stamina;
        }
    }
}
