using Originly_MVC5.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Originly_MVC5.ViewModels;

namespace Originly_MVC5.Controllers
{
    public class GamesController : Controller
    {
        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();  
        }

        // GET: Games
        public ViewResult Index()
        {
            //var games = _context.Games.Include(g=>g.Genre).ToList();

            //return View(games);
            if(User.IsInRole(RoleName.CanManageGames))
            return View("List");
            return View("ReadOnlyList");

        }

        public ActionResult Details(int id)
        {
            var game = _context.Games.Include(g=>g.Genre).SingleOrDefault(c => c.Id == id);
            if (game == null)
                return HttpNotFound();

            return View(game);
        }

        [Authorize(Roles = RoleName.CanManageGames)]
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new GameFormViewModel
            {
                Genres = genres
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageGames)]
        public ActionResult Create(Game game)
        {
            game.DateAdded = DateTime.Now;
            _context.Games.Add(game);

            _context.SaveChanges();

            return RedirectToAction("Index", "Games");
        }

        [Authorize(Roles = RoleName.CanManageGames)]
        public ActionResult Edit(int id)
        {
            var game = _context.Games.SingleOrDefault(g => g.Id == id);

            if (game == null)
                return HttpNotFound();

            var viewModel = new GameFormViewModel
            {
                Game=game,
                Genres = _context.Genres.ToList()

            };
            return View(viewModel);
        }

        [Authorize(Roles = RoleName.CanManageGames)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Game game)
        {
            var gameInDb = _context.Games.Single(g => g.Id == game.Id);
            gameInDb.Name = game.Name;
            gameInDb.ReleaseDate = game.ReleaseDate;
            gameInDb.GenreId = game.GenreId;

            _context.SaveChanges();
            return RedirectToAction("Index", "Games");
        }

        
    }
}