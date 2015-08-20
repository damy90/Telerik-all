using System;
using System.ComponentModel.DataAnnotations;

namespace BulsAndCows.Models
{
    public class Game
    {
        public Game()
        {
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public GameStateEnum GameState { get; set; }

        public DateTime DateCreated { get; set; }

        public string RedUserNumber { get; set; }

        public string BlueUserNumber { get; set; }

        public string RedPlayerId { get; set; }

        public virtual ApplicationUser RedPlayer { get; set; }

        public string BluePlayerId { get; set; }

        public virtual ApplicationUser BluePlayer { get; set; }

        public Guid WinnerId { get; set; }

        public virtual ApplicationUser Winner { get; set; }
    }
}
