using Andresom.Entities;
using Andresom.Heroes;

namespace Andresom.Enemies
{
    abstract internal class Enemy : Entity
    {
        public float PhisycalResist { get; private protected set; } = 0;
        public float MagicResist { get; private protected set; } = 0;
        public float RangeResist { get; private protected set; } = 0;

        public Enemy(float phisycalResist, float magicResist, float rangeResist, string model, byte health, byte stamina) : base(model, health, stamina)
        {
            PhisycalResist = phisycalResist;
            MagicResist = magicResist;
            RangeResist = rangeResist;
        }

        public void RestoreStamina(Enemy enemy) => StaminaSettings(enemy);
    }
}
