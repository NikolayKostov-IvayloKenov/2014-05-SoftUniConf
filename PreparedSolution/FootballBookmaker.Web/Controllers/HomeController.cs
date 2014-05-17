using FootballBookmaker.Data;
using FootballBookmaker.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballBookmaker.Web.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();

        public ActionResult Index()
        {
            var games = db.Games.Where(x => !x.HomeScore.HasValue).Select(x => new GameInfoViewModel
                {
                    Id = x.Id,
                    HomeTeam = x.HomeTeam.Name,
                     AwayTeam = x.AwayTeam.Name,
                     PredictionsCount = x.Predictions.Count()
                }).OrderByDescending(x => x.PredictionsCount);
            var viewModel = new HomePageViewModel
            {
                Games = games.ToList()
            };
            return View(viewModel);
        }
    }
}