namespace FootballBookmaker.DataClient
{
    using FootballBookmaker.Data;
    using FootballBookmaker.Data.Migrations;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataClient
    {
        public static void Main()
        {
            Database.SetInitializer<DataContext>(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
            var data = new DataContext();

            var games = data.Games.Where(g => !g.HomeScore.HasValue).Select(g =>
                new
                {
                    HomeTeamName = g.HomeTeam.Name,
                    AwayTeamName = g.AwayTeam.Name
                });

            foreach (var game in games)
            {
                Console.WriteLine("{0} - {1}", game.HomeTeamName, game.AwayTeamName);
            }
        }
    }
}
