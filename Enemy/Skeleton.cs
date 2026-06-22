using Andresom.Enemies;

namespace Andresom.Skeletones
{
    internal class Skeleton : Enemy
    {
        public Skeleton(float phisycalResist, float magicResist, float rangeResist, string model, byte health, byte stamina) : base(phisycalResist, magicResist, rangeResist, model, health, stamina)
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
