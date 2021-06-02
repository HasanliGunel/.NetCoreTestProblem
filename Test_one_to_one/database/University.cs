using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_one_to_one.database
{
    public class University
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<UniversityStudent> UniversityStudents { get; set; }

    }
}
