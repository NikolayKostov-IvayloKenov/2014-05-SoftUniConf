using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballBookmaker.Web.Models
{
    public class DetailedGameInfoViewModel : GameInfoViewModel
    {
        public IEnumerable<PredictionInfoViewModel> Predictions { get; set; }
    }
}