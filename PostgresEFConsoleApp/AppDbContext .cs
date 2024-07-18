using Microsoft.EntityFrameworkCore;
using System;

namespace PostgresEFConsoleApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=StudentDB";
            optionsBuilder.UseNpgsql(connectionString);
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Students)
                .WithOne(s => s.Teacher)
                .HasForeignKey(s => s.TeacherId)
                .IsRequired();


            modelBuilder.Entity<Teacher>().HasKey(t => t.Id);
            modelBuilder.Entity<Student>().HasKey(s => s.Id);
        }
    }
}
