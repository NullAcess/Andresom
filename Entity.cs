namespace Entity_Name
{
    internal class Entity
    {
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public Entity(int health, int attack, int defense)
        {
            Health = health;
            Attack = attack;
            Defense = defense;
        }
        public void AttackEnemy(Entity enemy)
        {
            // Implement attack logic here
        }
        public void Defend()
        {
            // Implement defend logic here
        }
    }
    internal class Knight : Entity
    {
        public Knight(int health, int attack, int defense) : base(health, attack, defense)
        {
            Console.WriteLine("вызвался рыцарь");
        }
    }
    internal class Archer : Entity
    {
        public Archer(int health, int attack, int defense) : base(health, attack, defense)
        {
            Console.WriteLine("вызвался лучник");
        }
    }
    internal class Wizard : Entity
    {
        public Wizard(int health, int attack, int defense) : base(health, attack, defense)
        {
            Console.WriteLine("вызвался маг");
        }
    }
    internal class Enemy : Entity
    {
        public Enemy(int health, int attack, int defense) : base(health, attack, defense)
        {
            Console.WriteLine("вызвался враг");
        }
    }
}
