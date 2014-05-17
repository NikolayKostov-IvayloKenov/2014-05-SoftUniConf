using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballPredictions.Web.Models
{
    public class HomeGameDetailsViewModel
    {
        public int Id { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public int PredictionsCount { get; set; }
    }
}