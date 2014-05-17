using FootballBookmaker.Data;
using FootballBookmaker.Models;
using FootballBookmaker.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballBookmaker.Web.Controllers
{
    public class GamesController : Controller
    {
        DataContext db = new DataContext();

        public ActionResult Show(int id)
        {
            var viewModel = db.Games.Where(x => x.Id == id).Select(x => new DetailedGameInfoViewModel
                {
                    Id = x.Id,
                    AwayTeam = x.AwayTeam.Name,
                    HomeTeam = x.HomeTeam.Name,
                    Predictions = x.Predictions.Select(y => new PredictionInfoViewModel
                    {
                        GameResult = y.PredictedResult,
                        Username = y.User.UserName
                    }),
                    PredictionsCount = x.Predictions.Count(),
                }).FirstOrDefault();

            return View(viewModel);
        }

        public ActionResult CreatePrediction(int id, GameResult gameResult)
        {
            string currentUserName = User.Identity.Name;
            ApplicationUser currentUser = db.Users.FirstOrDefault(x => x.UserName == currentUserName);

            this.db.Predictions.Add(new Prediction
               {
                   GameId = id,
                   PredictedResult = gameResult,
                   User = currentUser,
               });

            this.db.SaveChanges();

            return Content(string.Format("<li>{0}: {1}</li>", currentUser.UserName, gameResult.ToPredictionString()));
        }
    }
}