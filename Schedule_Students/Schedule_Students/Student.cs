using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Students
{
    public class Student
    {
        public int student_id { get; set; }
        public int gender { get; set; }
        public string student_fname { get; set; }
        public string student_lname { get; set; }
        public string student_mobile { get; set; }
        public string student_email { get; set; }
        public string student_college_id { get; set; }
        public List<int> Course_id { get; set; }
        public List<int> Course_time { get; set; }

    }

}
