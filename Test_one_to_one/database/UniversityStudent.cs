using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_one_to_one.database
{
    public class UniversityStudent
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int UniversityID { get; set; }
        public Student Student { get; set; }
        public University University { get; set; }
    }
}
