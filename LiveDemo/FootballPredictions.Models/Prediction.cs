namespace FootballPredictions.Models
{
    public class Prediction
    {
        public int Id { get; set; }

        public Game Game { get; set; }

        public GameResult Result { get; set; }

        // TODO: prediction should have user
    }
}
