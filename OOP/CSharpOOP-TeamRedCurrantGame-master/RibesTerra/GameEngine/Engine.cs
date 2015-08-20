namespace GameEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using GameEngine.Factories;

    using Models;
    using Models.Creatures;
    using Models.Interfaces;
    using Models.Gear.Items;
    using Models.Gear.Weapons;
    using Models.Extensions;

    public class Engine
    {
        private static readonly Engine InitialInstance = new Engine();

        private ICollection<ICreature> enemyUnits;
        private ICollection<IItem> playerCharacterItem;
        private ICollection<IWeapon> playerCharacterWeapon;
        private ICharacter playerCharacter;

        private ICreatureFactory creatureFactory;
        private IGearFactory gearFactory;

        public Engine()
        {
            this.creatureFactory = new CreatureFactory();
            this.gearFactory = new GearFactory();

            this.enemyUnits = new List<ICreature>();
            this.playerCharacterItem = new List<IItem>();
            this.playerCharacterWeapon = new List<IWeapon>();
        }

        //event 
        public event EventHandler NextLevelReached;

        public static Engine Instance
        {
            get
            {
                return InitialInstance;
            }
        }

        public void ParseCommand(string command)
        {
            //string[] commandWordSeparators = new string[] { " " };

            //string[] commandWords = command.Split(commandWordSeparators, StringSplitOptions.RemoveEmptyEntries);

            if (playerCharacter == null)
            {
                InitializeGameCommand(command);
            }
            var commandResult = ProceedCommand(command);
            
        }

        private void InitializeGameCommand(string command)
        {
            playerCharacter = InitializeCharacter(command);

            Console.WriteLine(playerCharacter.ToString());

            enemyUnits = InitializeEnemyUnits(enemyUnits);
            
            var easiestEnemy = SortEasiestEnemy(enemyUnits);

            Console.WriteLine(easiestEnemy.ToString());

            HandleBattle(playerCharacter,easiestEnemy);
        }

        private ICharacter InitializeCharacter(string command)
        {
            playerCharacter = creatureFactory.CreateCharacter(command, (GenderType)RandomGenerator.Instance.Next(0, 2));

            playerCharacterItem = gearFactory.CreateItemSet("Item", 20, 20, 20);
            playerCharacterWeapon = gearFactory.CreateWeaponSet("Weapon", 20, 20, 20);

            playerCharacter.AddItemsList(playerCharacterItem);
            playerCharacter.AddWeaponList(playerCharacterWeapon);

            return playerCharacter;
            
        }

        private ICollection<ICreature> InitializeEnemyUnits(ICollection<ICreature> enemyUnits)
        {
            for (int i = 0; i < 5; i++)
            {
                enemyUnits.Add(creatureFactory.CreateEnemy("Orcas", GenderType.Male));
            }

            return enemyUnits;
        }

        private ICreature SortEasiestEnemy(IEnumerable<ICreature> enemyUnits)
        {
            return enemyUnits
                    .OrderBy(e => e.BasePower)
                    .ThenBy(e => e.BaseHealth)
                    .FirstOrDefault();
        }

        private ICreature SortHardestEnemy(IEnumerable<ICreature> enemyUnits)
        {
            return enemyUnits
                    .OrderByDescending(e => e.BasePower)
                    .ThenByDescending(e => e.BaseHealth)
                    .FirstOrDefault();
        }

        private void HandleBattle(ICharacter playerCharacter, ICreature enemyUnit)
        {
            if (playerCharacter == null)
            {
                throw new ArgumentNullException("playerCharacter");
            }

            if (enemyUnit == null)
            {
                throw new ArgumentNullException("enemyUnit");
            }

            var easiestEnemy = SortEasiestEnemy(enemyUnits);

            Console.WriteLine(easiestEnemy.ToString());

            var playerAsGameObject = playerCharacter as GameObject;
            var enemyAsGameObject = enemyUnit as GameObject;

            Engine.Instance.NextLevelReached += MoveToNextLevel;

            while (true)
            {
                enemyUnit.BaseHealth -= playerCharacter.BasePower;

                if (enemyUnit.BaseHealth < 0)
                {
                    Console.WriteLine(ConsoleMessageConstants.EnemySlainMessage, enemyAsGameObject.Name);
                    Console.WriteLine(ConsoleMessageConstants.MoveToNextLevelMessage);

                    enemyUnits.Remove(enemyUnit);

                    OnNextLevelReached(EventArgs.Empty);
                    break;
                }
                else
                {
                    Console.WriteLine(ConsoleMessageConstants.EnemyTakeDamageMessage,playerAsGameObject.Name, playerCharacter.BasePower, enemyAsGameObject.Name);
                }
                
                playerCharacter.BaseHealth -= enemyUnit.BasePower;

                if (playerCharacter.BaseHealth < 0)
                {
                    Console.WriteLine(ConsoleMessageConstants.PlayerSlainMessage, playerAsGameObject.Name);
                    Console.WriteLine(ConsoleMessageConstants.GameOverMessage);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine(ConsoleMessageConstants.PlayerTakeDamageMessage,enemyAsGameObject.Name, enemyUnit.BasePower, playerAsGameObject.Name);
                }
            }
        }

        protected virtual void OnNextLevelReached(EventArgs e)
        {
            if (Engine.Instance.NextLevelReached != null)
            {
                Engine.Instance.NextLevelReached(this, e);
            }
        }

        public void MoveToNextLevel(object sender, EventArgs e)
        {
            this.playerCharacter.BaseHealth += 50;
            this.playerCharacter.BasePower += 50;

            foreach (ICreature enemy in enemyUnits)
            {
                var enemyUnitAsCreature = enemy as ICreature;
                if (enemyUnitAsCreature != null)
                {
                    enemyUnitAsCreature.BaseHealth += RandomGenerator.Instance.Next(0, 40);
                    enemyUnitAsCreature.BasePower += RandomGenerator.Instance.Next(0, 40);
                }
            }
        }
        
        private string ProceedCommand(string command)
        {
            switch (command)
            {
                case "attack":
                case "shop":
                default:
                    return string.Format(ConsoleMessageConstants.InvalidCommandMessage, command);
            }
        }
    }
}
