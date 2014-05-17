namespace FootballPredictions.ConsoleClient
{
    using FootballPredictions.Data;
    using FootballPredictions.Data.Migrations;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ConsoleClient
    {
        public static void Main()
        {
            Database.SetInitializer<DataContext>(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
            var data = new DataContext();

            var futureGames = data.Games
                .Where(g => !g.HomeScore.HasValue)
                .Select(g => new
                {
                    HomeName = g.HomeTeam.Name,
                    AwayName = g.AwayTeam.Name
                })
                .ToList();

            foreach (var game in futureGames)
            {
                Console.WriteLine("{0} - {1}", game.HomeName, game.AwayName);
            }
        }
    }
}
