using Originly_MVC5.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            var games = _context.Games.Include(g=>g.Genre).ToList();

            return View(games);

        }

        public ActionResult Details(int id)
        {
            var game = _context.Games.Include(g=>g.Genre).SingleOrDefault(c => c.Id == id);
            if (game == null)
                return HttpNotFound();

            return View(game);
        }


        
    }
}