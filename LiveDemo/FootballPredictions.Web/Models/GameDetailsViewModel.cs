using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballPredictions.Web.Models
{
    public class GameDetailsViewModel
    {
        public string HomeTeam { get; set; }

        public string AwayTeam { get; set; }

        public IEnumerable<PredictionViewModel> Predictions { get; set; }
    }
}