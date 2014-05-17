namespace FootballBookmaker.Models
{
    public enum GameResult
    {
        HomeWon = 1,
        AwayWon = 2,
        Draw = 3,
    }

    public static class GameResultExtensions
    {
        public static string ToPredictionString(this GameResult result)
        {
            switch (result)
            {
                case GameResult.HomeWon:
                    return "1";
                case GameResult.AwayWon:
                    return "2";
                case GameResult.Draw:
                    return "X";
                default:
                    return "?";
            }
        }
    }
}
