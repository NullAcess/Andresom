using Andresom.Archeres;
using Andresom.Bowes;
using Andresom.DamageTypes;
using Andresom.Enemies;
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
using Andresom.Handes;

namespace Program;

class Program
{
    private static int countOfWaves = 10;
    private static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Weapon sword = new Sword();
        Weapon magicStick = new MagicStick();
        Weapon bow = new Bow();
        Weapon nastyClub = new NastyClub();
        Weapon hands = new Hand();
        Random random = new Random();
        Hero userHero;
        Enemy enemy;

        Screen.LoadingGame();
        HeroType heroType = Screen.ChooseHero();
        switch (heroType)
        {
            case HeroType.Knight: userHero = new Knight(weapon: sword, model: Model.KnightSprite); break;
            case HeroType.Wizzard: userHero = new Wizzard(weapon: magicStick, model: Model.WizzardSprite); break;
            case HeroType.Archer: userHero = new Archer(weapon: bow, model: Model.ArcherSprite); break;
            default: userHero = new Knight(weapon: sword, model: Model.KnightSprite); break;
        }

        for(int i = countOfWaves; i > 0; i--)
        {
            int enemyType = random.Next(1, 101); // рандомно выбираем число
            if(enemyType <= 50) enemy = new Skeleton(weapon: hands, model: Model.SkeletonSprite);
            else enemy = new Orc(weapon: nastyClub, model: Model.OrcSprite);

            Screen.Fight(enemy: enemy, user: userHero, countOfWaves: ref i); // NOTE: ПОТОМ СДЕЛАТЬ ВЫБОР ПО ВОЛНАМ.
        }

        Screen.Win();
    }
}