using GRTHabitation.Models.Database.EntityObjects;
using Microsoft.EntityFrameworkCore;

namespace GRTHabitation.Models.Database
{
    
    public class GRTHDbContext : DbContext {
        
        private const string Server = "127.0.0.1";
        private const string  Port = "5432";
        private const string  Name = "GRTH";
        private const string  User = "etudiant";
        private const string  Password = "Etudiant1";
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                $"Host={Server};" +
                $"Port={Port};" +
                $"Database={Name};" +
                $"Username={User};" +
                $"Password={Password};"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Housing> Housings { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<User> Users { get; set; }
    }
    
}