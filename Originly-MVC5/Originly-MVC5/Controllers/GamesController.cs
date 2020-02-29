using Originly_MVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Originly_MVC5.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public ViewResult Index()
        {
            var games = GetGames();

            return View(games);

        }

        public ActionResult Details(int id)
        {
            var game = GetGames().SingleOrDefault(c => c.Id == id);
            if (game == null)
                return HttpNotFound();

            return View(game);
        }


        private IEnumerable<Game> GetGames()
        {
            return new List<Game>
            {
                new Game{Id=1,Name="GTA5"},
                new Game{Id=2,Name="Metin2"}
            };
        }
    }
}