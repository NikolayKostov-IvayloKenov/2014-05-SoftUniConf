using FootballPredictions.Data;
using FootballPredictions.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballPredictions.Web.Controllers
{
    public class GamesController : Controller
    {
        DataContext data = new DataContext();

        public ActionResult Details(int id)
        {
            var viewModel = data.Games
                .Where(x => x.Id == id)
                .Select(x => new GameDetailsViewModel
                {
                    HomeTeam = x.HomeTeam.Name,
                    AwayTeam = x.AwayTeam.Name,
                    Predictions = x.Predictions.Select(
                        y => new PredictionViewModel
                        {
                            Result = y.Result,
                            Username = "Anonymous",
                        })
                })
                .FirstOrDefault();

            if (viewModel == null)
            {
                return HttpNotFound();
            }

            return View(viewModel);
        }
    }
}