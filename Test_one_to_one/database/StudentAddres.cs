using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_one_to_one.database
{
    public class StudentAddres
    {
        public int ID { get; set; }
        public int StudentId { get; set; }
        public int AddressID { get; set; }
        public Student Student { get; set; }
        public Address Address { get; set; }
    }
}
