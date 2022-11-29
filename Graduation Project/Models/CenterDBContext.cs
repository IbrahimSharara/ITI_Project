 using Microsoft.EntityFrameworkCore;

namespace El_Tamayez.Models
{
    public class CenterDBContext:DbContext
    {
        public CenterDBContext(DbContextOptions options) :base(options)
        {

        }
        public CenterDBContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-S9RDLNO\\MSSQLSERVER2;Database=ElTamayezDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentSubjectGroupTeacher>()
                .HasKey("StudentId", "SubjectId", "TeacherId", "GroupId");
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ContactUs> ContactUss { get; set; }

         public DbSet<StudentSubjectGroupTeacher> StudentsSubjectsGroupsTeachers { get; set; }



    }
}
