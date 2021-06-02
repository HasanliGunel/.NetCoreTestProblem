using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_one_to_one.database
{
    public class UniversityContext:DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> context) : base(context) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<StudentAddres> StudentAddress { get; set; }
        public DbSet<StudentGrade> StudentGrades { get; set; }
        public DbSet<UniversityStudent> UniversityStudents { get; set; }
    }
}
