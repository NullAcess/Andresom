using Andresom.Archeres;
using Andresom.Bowes;
using Andresom.DamageTypes;
using Andresom.Enemies;
using Andresom.EnemyTypes;
using Andresom.Heroes;
using Andresom.HeroTypes;
using Andresom.Knightes;
using Andresom.MagicStickes;
using Andresom.Models;
using Andresom.NastyClubes;
using Andresom.Orcses;
using Andresom.Screenes;
using Andresom.Skeletones;
using Andresom.Swordes;
using Andresom.Weapones;
using Andresom.Wizzardes;

namespace Program;

class Program
{
    private static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Weapon sword = new Sword(requirementEnergy: 20, DamageType.PhysicalResist, damage: 40);
        Weapon magicStick = new MagicStick(requirementEnergy: 15, DamageType.MagicDamage, damage: 25);
        Weapon bow = new Bow(requirementEnergy: 10, DamageType.RangeDamage, damage: 15);
        Weapon nastyClub = new NastyClub(requirementEnergy: 30, DamageType.PhysicalResist, damage: 70);
        Weapon hands = new Hands(requirementEnergy: 15, DamageType.PhysicalResist, damage: 20);
        Random random = new Random();
        Hero userHero;
        Enemy npcEnemy;

        Screen.LoadingGame();
        HeroType heroType = Screen.ChooseHero();
        switch (heroType)
        {
            case HeroType.Knight: userHero = new Knight(weapon: sword, model: Model.KnightSprite, health: 250, stamina: 100, physicalResist: 0.3f); break;
            case HeroType.Wizzard: userHero = new Wizzard(weapon: magicStick, model: Model.WizzardSprite, health: 150, stamina: 100, physicalResist: 0.8f); break;
            case HeroType.Archer: userHero = new Archer(weapon: bow, model: Model.ArcherSprite, health: 200, stamina: 100, physicalResist: 0.6f); break;
            default: userHero = new Knight(weapon: sword, model: Model.KnightSprite, health: 250, stamina: 100, physicalResist: 0.2f); break;
        }

        byte enemyTypeValue = (byte)(random.Next(1,3));
        EnemyType enemyType = (EnemyType)enemyTypeValue;
        switch (enemyType)
        {
            case EnemyType.Skeleton: npcEnemy = new Skeleton(weapon: hands, physicalResist: 0.9f, magicResist: 0.4f, rangeResist: 0.3f, model: Model.SkeletonSprite, health: 50, stamina: 100); break;
            case EnemyType.Orc: npcEnemy = new Orc(weapon: nastyClub,physicalResist: 0.5f, magicResist: 0.9f, rangeResist: 0.8f, model: Model.OrcSprite, health: 250, stamina: 100); break;
            default: npcEnemy = new Orc(weapon: nastyClub, physicalResist: 0.4f, magicResist: 0.9f, rangeResist: 0.8f, model: Model.OrcSprite, health: 250, stamina: 100); break;
        }

        Screen.Fight(enemy: npcEnemy, user: userHero); // NOTE: ПОТОМ СДЕЛАТЬ ВЫБОР ПО ВОЛНАМ.
    }
}