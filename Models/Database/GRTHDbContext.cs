using GRTHabitation.Models.Database.EntityObjects;
using Microsoft.EntityFrameworkCore;

namespace GRTHabitation.Models.Database
{
    
    public class GRTHDbContext : DbContext {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string server = "127.0.0.1";
            const string  port = "5432";
            const string  name = "GRTH";
            const string  user = "etudiant";
            const string  password = "Etudiant1";
            optionsBuilder.UseNpgsql(
                $"Host={server};Port={port};Database={name};Username={user};Password={password}"
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