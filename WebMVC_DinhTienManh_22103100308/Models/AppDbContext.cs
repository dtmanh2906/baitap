using Microsoft.EntityFrameworkCore;

namespace WebMVC_DinhTienManh_22103100308.Models

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Result> Results { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                 new Student { StudentId = 1, FullName = "A", BrithDate = new DateTime(2002, 1, 1) },
                 new Student { StudentId = 2, FullName = "B", BrithDate = new DateTime(2002, 2, 2) },
                 new Student { StudentId = 3, FullName = "C", BrithDate = new DateTime(2002, 3, 3) }
                );
            modelBuilder.Entity<Result>().HasData(
                  new Result { ResultID = 1, StudentID = 1, Subject = "Toán", Score = 9 },
                  new Result { ResultID = 2, StudentID = 1, Subject = "Van", Score = 8 },
                  new Result { ResultID = 3, StudentID = 2, Subject = "Ly", Score = 8 },
                  new Result { ResultID = 4, StudentID = 2, Subject = "Hoa", Score = 7 },
                  new Result { ResultID = 5, StudentID = 3, Subject = "Anh", Score = 8 },
                  new Result { ResultID = 6, StudentID = 3, Subject = "Su", Score = 7 }
                );
        }
    }
}