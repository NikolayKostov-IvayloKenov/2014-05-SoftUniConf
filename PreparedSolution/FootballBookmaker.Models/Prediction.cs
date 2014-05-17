using System.ComponentModel.DataAnnotations;
namespace FootballBookmaker.Models
{
    public class Prediction
    {
        [Key]
        public int Id { get; set; }

        public int GameId { get; set; }

        public virtual Game Game { get; set; }

        public virtual ApplicationUser User { get; set; }

        public GameResult PredictedResult { get; set; }
    }
}
