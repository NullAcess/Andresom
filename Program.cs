using Andresom.Archeres;
using Andresom.Bowes;
using Andresom.DamageTypes;
using Andresom.Entities;
using Andresom.Heroes;
using Andresom.HeroTypes;
using Andresom.Knight;
using Andresom.MagicStickes;
using Andresom.Models;
using Andresom.Orcs;
using Andresom.Screenes;
using Andresom.Skeletones;
using Andresom.Swordes;
using Andresom.Weapones;
using Andresom.Wizzard;

namespace Program
{
    class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Hero userHero;
            Screen.LoadingGame();

            HeroType heroType = Screen.ChooseHero();

            Weapon sword = new Sword(requirementEnergy: 20, DamageType.PhysicalDamage, damage: 40);
            Weapon magicStick = new MagicStick(requirementEnergy: 20, DamageType.MagicDamage, damage: 25);
            Weapon bow = new Bow(requirementEnergy: 20, DamageType.RangeDamage, damage: 15);
            switch (heroType)
            {
                case HeroType.Knight: userHero = new Knight(weapon: sword, model: Model.KnightSprite, health: 250, stamina: 100); break;
                case HeroType.Wizzard: userHero = new Wizzard(weapon: magicStick, model: Model.WizzardSprite, health: 150, stamina: 100); break;
                case HeroType.Archer: userHero = new Archer(weapon: bow, model: Model.ArcherSprite, health: 200, stamina: 100); break;
                default: userHero = new Knight(weapon: sword, model: Model.KnightSprite, health: 250, stamina: 100); break;
            }

            var enemyOrc = new Orc(phisycalResist: 0.4f, magicResist: 0.9f, rangeResist: 0.8f, model: Model.OrcSprite, health: 250, stamina: 100);
            var enemySkeleton = new Skeleton(phisycalResist: 0.9f, magicResist: 0.4f, rangeResist: 0.3f, model: Model.SkeletonSprite, health: 50, stamina: 100);

            // TODO: ПОКА ЧТО ПЕРЕДАЕМ ОРКА, ПОТОМ СДЕЛАТЬ ВЫБОР ПО ВОЛНАМ.

            Screen.Fight(enemy: enemyOrc, user: userHero);
        }
    }
}