using FootballBookmaker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballBookmaker.Web.Models
{
    public class PredictionInfoViewModel
    {
        public GameResult GameResult { get; set; }

        public string Username { get; set; }

        public string ResultAsString
        {
            get
            {
                return this.GameResult.ToPredictionString();
            }
        }
    }
}