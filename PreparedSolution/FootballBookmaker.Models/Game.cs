namespace FootballBookmaker.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
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

        public byte? HomeScore { get; set; }

        public byte? AwayScore { get; set; }

        public virtual ICollection<Prediction> Predictions
        {
            get { return this.predictions; }
            set { this.predictions = value; }
        }

        /// <summary>
        /// If result is null - the game has not finished yet
        /// </summary>
        [NotMapped]
        public GameResult? Result
        {
            get
            {
                if (!HomeScore.HasValue || !AwayScore.HasValue)
                {
                    return null;
                }
                else if (HomeScore.Value > AwayScore.Value)
                {
                    return GameResult.HomeWon;
                }
                else if (HomeScore.Value < AwayScore.Value)
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