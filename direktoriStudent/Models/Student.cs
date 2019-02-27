using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace direktoriStudent.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //lookup
        public int LecturerID { get; set; }
        public Lecturer Lecturer { get; set; }
    }
}
