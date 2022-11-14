using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SportsSchedule.Infrastructure.Data;
using SportsSchedule.Infrastructure.Data.Configuration;
using System.Data;
using System.Reflection.Emit;

namespace SportsSchadule.Infrastucture.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SportsHalls>()
                .HasKey(sh => new { sh.HallId, sh.SportId });

            builder.Entity<TrainingsUsers>()
              .HasKey(tu => new { tu.TrainingId, tu.UserId });

            builder.Entity<SportsUsers>()
             .HasKey(su => new { su.SportId, su.UserId });

            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new SportConfiguration());
            builder.ApplyConfiguration(new HallConfiguration());
            builder.ApplyConfiguration(new SportsHallsConfiguration());
        }

        public DbSet<Hall> Halls { get; set; } = null!;

        public DbSet<Sport> Sports { get; set; } = null!;

        public DbSet<Training> Trainings { get; set; } = null!;

        public DbSet<SportsHalls> SportsHalls { get; set; } = null!;

        public DbSet<TrainingsUsers> TrainingsUsers { get; set; } = null!;

        public DbSet<SportsUsers> SportsUsers { get; set; } = null!;


    }
}