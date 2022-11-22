using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requests
{
    public class Teacher
    {
        private string name;
        private string teacher_id;
        private Comment availbleDays = new Comment(); //מערך באורך 6 של ימי חול בשבוע בהם המורה יכול  לעבוד
                                                      //אם המורה עובד ביום מסויים יהיה אמת אחרת שקר
                                                      //על המערך להיראות כך [T,F,T,T,F,T]
        private List<Course> courses; // רשימה של כל הקורסים  אותם המורה יכול ללמד
        public Teacher(string name, string id, Comment availbleDays, List<Course> courses) //,פעולה בונה המקבלת את שם המורה
                                                                                           //מערך של ימי השבוע בו עובד והקורסים אותם מלמד
        {
            this.name = name;
            this.teacher_id = id;
            this.availbleDays = availbleDays;
            this.courses = courses;
        }
        public string GetName()//פעולה המחזירה את שם המורה
        {
            return name;
        }
        public string getID() { return teacher_id; }
        public Comment getDays() { return this.availbleDays; }
        public List<Course> getCourses() { return this.courses; }
    }
}
