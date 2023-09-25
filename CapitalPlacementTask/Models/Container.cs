using DataAccessLayer.Models.ApplicationForm;
using Microsoft.EntityFrameworkCore;

namespace CapitalPlacementTask.Models
{
    public class Container : DbContext
    {
        public Container(DbContextOptions<Container> options) : base(options)
        {

        }

        public DbSet<ProgramDetails> ProgramDetails { get; set; }
        public DbSet<ApplicationPage> AppPage { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<PersonalInformation> PersonalInformation { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Question> Questions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseCosmos(
                "CosmosDBEndpoint",
                "PrimaryKey",
                databaseName: "AppDB"
            );
        }

        

    }
}
