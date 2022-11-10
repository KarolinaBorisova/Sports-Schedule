using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportsSchedule.Infrastructure.Data;
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

            builder.Entity<Hall>()
                .HasKey(h => h.Id);

            builder.Entity<Hall>()
                .HasOne(p => p.AddressHall)
                .WithMany()
                .HasForeignKey(h=>h.AddressHallId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<AddressHall>()
              .HasKey(a => a.Id);

            builder.Entity<AddressHall>()
                .HasOne(a => a.Hall)
                .WithMany()
                .HasForeignKey(h => h.HallId)
            .OnDelete(DeleteBehavior.SetNull);





            base.OnModelCreating(builder);
        }

        public DbSet<Hall> Halls { get; set; } = null!;

        public DbSet<Sport> Sports { get; set; } = null!;

        public DbSet<Training> Trainings { get; set; } = null!;

        public DbSet<SportsHalls> SportsHalls { get; set; } = null!;

        public DbSet<TrainingsUsers> TrainingsUsers { get; set; } = null!;

        public DbSet<SportsUsers> SportsUsers { get; set; } = null!;

        public DbSet<AddressHall> AddressHalls { get; set; } = null!;

    }
}