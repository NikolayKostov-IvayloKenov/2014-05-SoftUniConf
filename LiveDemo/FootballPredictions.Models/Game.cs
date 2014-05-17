namespace FootballPredictions.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Game
    {
        private ICollection<Prediction> predictions;

        public Game()
        {
            this.Predictions = new HashSet<Prediction>();
        }

        public int Id { get; set; }

        public virtual Team HomeTeam { get; set; }

        public virtual Team AwayTeam { get; set; }

        public int? HomeScore { get; set; }

        public int? AwayScore { get; set; }

        public virtual ICollection<Prediction> Predictions
        {
            get { return this.predictions; }
            set { this.predictions = value; }
        }

        [NotMapped]
        public GameResult Result
        {
            get
            {
                if (!HomeScore.HasValue 
                    || !AwayScore.HasValue)
                {
                    return GameResult.NotFinished;
                }
                else if (HomeScore > AwayScore)
                {
                    return GameResult.HomeWon;
                }
                else if (AwayScore > HomeScore)
                {
                    return GameResult.AwayWon;
                }
                else // HomeScore == AwayScore
                {
                    return GameResult.Draw;
                }
            }
        }
    }
}
