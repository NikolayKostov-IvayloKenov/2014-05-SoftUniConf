using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballBookmaker.Web.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<GameInfoViewModel> Games { get; set; }
    }
}