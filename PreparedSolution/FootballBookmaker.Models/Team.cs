namespace FootballBookmaker.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Team
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
