namespace Program
{
    class Program
    {
        private static void Main()
        {
            Screen.LoadingGame();
            Screen.ChooseHero();
            Knight knight = new Knight(100, 20, 10);
            Archer archer = new Archer(80, 25, 5);
            Wizard wizard = new Wizard(60, 30, 3);
            Entity enemy = new Enemy(120, 15, 8);
        }
    }
}