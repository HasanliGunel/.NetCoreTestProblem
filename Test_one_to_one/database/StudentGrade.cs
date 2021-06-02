using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_one_to_one.database
{
    public class StudentGrade
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int GradeID { get; set; }
        public Student Students { get; set; }
        public Grade Grade { get; set; }
    }
}
