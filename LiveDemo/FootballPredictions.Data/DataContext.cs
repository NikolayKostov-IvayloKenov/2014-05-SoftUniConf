namespace FootballPredictions.Data
{
    using FootballPredictions.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;

    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<Prediction> Predictions { get; set; }

        public static DataContext Create()
        {
            return new DataContext();
        }
    }
}
