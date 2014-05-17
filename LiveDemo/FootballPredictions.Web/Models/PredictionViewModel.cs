using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FootballPredictions.Models;

namespace FootballPredictions.Web.Models
{
    public class PredictionViewModel
    {
        public GameResult Result { get; set; }

        public string Username { get; set; }
    }
}