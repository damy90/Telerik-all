using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using BulsAndCows.Data;
using BulsAndCows.Models;
using BulsAndCows.WebApi.Models;
using Microsoft.AspNet.Identity;

namespace BulsAndCows.WebApi.Controllers
{
    public class GamesController : BaseController
    {
        private const int PageSize = 10;
        private static readonly Random random = new Random();

        public GamesController(IBulsAndCowsData data)
            : base(data)
        {

        }

        [HttpGet]
        public IHttpActionResult Get(int page = 1)
        {
            var games = this.data.Games.All();
            var userID = this.User.Identity.GetUserId();
            IEnumerable<object> result;
            if (this.User.Identity.IsAuthenticated)
            {
                result = games.Where(g => g.BluePlayer == null || g.RedPlayerId == userID || g.BluePlayerId == userID);
            }
            else
            {
                result = games.Where(g => g.BluePlayer == null);
            }

            result = games.OrderBy(g => g.Name)
                .ThenBy(g => g.DateCreated)
                .ThenBy(g => g.RedPlayer.UserName)
                .Skip(Math.Max((page - 1), 0) * PageSize)
                .Take(PageSize).Select(GameDataModel.FromGame);

            return Ok(result);
        }

        [Authorize]
        [HttpPost]
        public IHttpActionResult Create(GameCreateModel model)
        {
            if (!IsValidUserNumber(model.Number))
            {
                return BadRequest("The number must be 4 didgits long and all didgits must be unique!");
            }
            GameDataModel viewModel = new GameDataModel();
            var userID = this.User.Identity.GetUserId();
            var userName = this.User.Identity.GetUserName();

            var game = new Game
            {
                RedUserNumber = model.Number,
                Name = model.Name,
                GameState = GameStateEnum.WaitingForOpponent,
                RedPlayerId = userID,
                DateCreated = DateTime.Now,
                //RedUserNumber=model.RedUserNumber
            };
            this.data.Games.Add(game);
            this.data.Games.SaveChanges();

            // TODO moove to method
            viewModel.Name = model.Name;
            viewModel.Id = game.Id;
            viewModel.GameState = game.GameState.ToString();
            viewModel.Red = userName;
            viewModel.Blue = "No blue player yet";
            viewModel.DateCreated = game.DateCreated;

            return Ok(viewModel);
        }

        [Authorize]
        [HttpPut]
        public IHttpActionResult Join(int id, GameCreateModel model)
        {
            var game = data.Games.All().FirstOrDefault(g => g.Id == id);
            if (game == null)
            {
                return BadRequest("The game doesn't exist!");
            }

            var userID = this.User.Identity.GetUserId();
            if (game.RedPlayerId == userID || game.BluePlayerId == userID)
            {
                return BadRequest("You have already joined this game!");
            }

            game.BlueUserNumber = model.Number;
            game.BluePlayerId = userID;
            game.GameState = random.Next(1, 3) == 1 ? GameStateEnum.RedInTurn : GameStateEnum.BlueInTurn;

            this.data.Games.Update(game);
            this.data.Games.SaveChanges();
            var result = new ResultModel
            {
                Result = string.Format("You joined game \"{0}\"", game.Name)
            };

            return Ok(result);
        }

        private bool IsValidUserNumber(string number)
        {
            if (number.Length != 4)
            {
                return false;
            }

            HashSet<char> uniqueDidgits = new HashSet<char>(number.ToCharArray());

            if (uniqueDidgits.Count != 4)
            {
                return false;
            }

            return true;
        }
    }
}
