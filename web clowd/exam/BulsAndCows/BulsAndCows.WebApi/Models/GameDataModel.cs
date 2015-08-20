using BulsAndCows.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace BulsAndCows.WebApi.Models
{
    public class GameDataModel
    {
        public static Expression<Func<Game, GameDataModel>> FromGame
        {
            get
            {
                return g => new GameDataModel
                {
                    Id=g.Id,
                    Name=g.Name,
                    GameState=g.GameState.ToString(),
                    Blue=g.BluePlayer==null? "No blue player yet": g.BluePlayer.UserName,
                    Red=g.RedPlayer.UserName,
                    //RedUserNumber=g.RedUserNumber,
                    //BlueUserNumber=g.BlueUserNumber,
                    DateCreated=g.DateCreated,

                };
            }
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Blue { get; set; }

        //public string RedUserNumber { get; set; }

        //public string BlueUserNumber { get; set; }

        [Required]
        public string Red { get; set; }

        [Required]
        public string GameState { get; set; }

        //[HiddenInput(DisplayValue = false)]
        //[ScaffoldColumn(false)]
        public DateTime DateCreated { get; set; }

        //public virtual ApplicationUser Winner { get; set; }
    }
}