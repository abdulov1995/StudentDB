using Microsoft.EntityFrameworkCore;


namespace PostgresEFConsoleApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<TeacherStudent> TeacherStudents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=StudentDB";
            optionsBuilder.UseNpgsql(connectionString);
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeacherStudent>()
                .HasKey(ts => new { ts.TeacherId, ts.StudentId });

            modelBuilder.Entity<TeacherStudent>()
                .HasOne(ts => ts.Teacher)
                .WithMany(t => t.TeacherStudents)
                .HasForeignKey(ts => ts.TeacherId);

            modelBuilder.Entity<TeacherStudent>()
                .HasOne(ts => ts.Student)
                .WithMany(s => s.TeacherStudents)
                .HasForeignKey(ts => ts.StudentId);
        }
    }
}
