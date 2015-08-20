namespace Models
{
    using System;
    using System.Text;

    using Models.Creatures;
    using Models.Interfaces;
    using System.Globalization;

    public class Character : Creature, ICreature, ICharacter
    {
        public const decimal InitialCharacterGold = 100;
        public const int InitialCharacterAttack = 50;
        public const int InitialCharacterHealth = 50;

        public Character(string name, GenderType gender)
            : base(name, Character.InitialCharacterAttack, Character.InitialCharacterHealth, gender)
        {
            this.GoldAmount = InitialCharacterGold;
            this.AddSpell(new Spell("Heal", 50, Spells.SpellType.HealSpell));
        }

        public decimal GoldAmount { get; private set; }
    }
}
