using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comment;

namespace schedule_project
{
    internal class Teacher
    {
        string name;
        Comment AvailbleDays = new Comment(); //מערך באורך 6 של ימי חול בשבוע בהם המורה יכול  לעבוד
                             //אם המורה עובד ביום מסויים יהיה אמת אחרת שקר
                             //על המערך להיראות כך [T,F,T,T,F,T]
        List<Course> courses; // רשימה של כל הקורסים  אותם המורה יכול ללמד
        Teacher(string name,bool[] availbleDays, List<Course> courses) //,פעולה בונה המקבלת את שם המורה
                                                                       //מערך של ימי השבוע בו עובד והקורסים אותם מלמד
        {
            this.name = name;
            AvailbleDays = availbleDays;
            this.courses = courses;
        }
        public string GetName()//פעולה המחזירה את שם המורה
        {
            return name;
        }
        public bool IsWorkingOn(int day)//פעולה המחזירה האם המורה עובד ביום מסויים
        {
            return AvailbleDays[day];
        }
        public List<string> CoursesNames(List<Course> courss)
        {
            List<string> coursesNames = new List<string>();
            foreach (Course c in courss)
            {
                coursesNames.Add(c.Name);
            }
            return coursesNames;
        }
        public bool IsTeaching(CourseName name)
        {
            List<string> courss = CoursesNames(courses);
            foreach (string n in courss)
            {
                if(n == name)
                    return true;
            }
            return false;
        }
    }
}
