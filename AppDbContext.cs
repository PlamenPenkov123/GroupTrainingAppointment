using GroupTrainingAppointment.Utilities.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupTrainingAppointment
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupParticipant> GroupParticipants { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
