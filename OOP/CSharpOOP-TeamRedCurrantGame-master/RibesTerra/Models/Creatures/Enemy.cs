namespace Models
{
    using System;
    using Models.Creatures;
    using Models.Extensions;
    using Models.Interfaces;

    public class Enemy : Creature, ICreature
    {
        public const int InitialEnemyAttack = 20;
        public const int InitialEnemyHealth = 100;

        public Enemy(string name, int power, int health, GenderType gender)
            : base(name, Enemy.InitialEnemyAttack + RandomGenerator.Instance.Next(20, 40), Enemy.InitialEnemyHealth + RandomGenerator.Instance.Next(20, 40), gender)
        {
           
        }

        public Enemy(string name, GenderType gender)
            : base(name, Enemy.InitialEnemyAttack + RandomGenerator.Instance.Next(20, 40), Enemy.InitialEnemyHealth + RandomGenerator.Instance.Next(20, 40), gender)
        {
        }
    }
}
