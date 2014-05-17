using FootballPredictions.Data;
using FootballPredictions.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballPredictions.Web.Controllers
{
    public class HomeController : Controller
    {
        DataContext data = new DataContext();

        public ActionResult Index()
        {
            var futureGames = data.Games
                .Where(g => !g.HomeScore.HasValue)
                .OrderByDescending(g => g.Predictions.Count())
                .Select(g => new HomeGameDetailsViewModel
                {
                    Id = g.Id,
                    HomeTeam = g.HomeTeam.Name,
                    AwayTeam = g.AwayTeam.Name,
                    PredictionsCount = g.Predictions.Count()
                })
                .Take(10)
                .ToList();

            ViewBag.Name = "Ivo";

            return View(futureGames);
        }
    }
}