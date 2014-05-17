using System.ComponentModel.DataAnnotations;
namespace FootballPredictions.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
