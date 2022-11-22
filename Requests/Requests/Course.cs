using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requests
{
    public class Course
    {
        private string name;
        private string id;

        public Course(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        public string getName()
        {
            return name;
        }
        public string getID()
        {
            return id;
        }
    }
}
