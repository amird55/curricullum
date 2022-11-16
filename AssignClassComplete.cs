using System;
using System.Collections.Generic;

namespace ClassSchedualing
{
    class ClassAssignment
    {
        private static Dictionary<string, string> CourseToKita = new Dictionary<string, string>() { };//  המטרה שלו היא לעקוב אחר איזה כיתות תפוסות והאם יש קורס שנמצא בכמה שעות רצוף
        public static Kita[] kitaList = new Kita[8];//רשימה של כיתות שאמורים לקבל כנתון קבוע- עדיין לא הוגדר הרשימה המוכנה

        public static List<Course>[,] assignAll(List<Course>[,] TimeTable)//פעולה ראשית - ד
        {
            int HourInDays = TimeTable.GetLength(0);
            int DaysInWeek = TimeTable.GetLength(1);
            List<Course>[,] Ctt = new List<Course>[HourInDays, DaysInWeek];//יצירת מערכת שעות שלמה עם כל הקורסים עם כיתה משובצת לכל קור בכל יום
            for (int day = 0; day < DaysInWeek; day++)//לעבור על כל יום
            {
                for (int hour = 0; hour < HourInDays; hour++)//לעבור על כל שעה
                {
                    Ctt[hour, day] = AssignClasses(TimeTable[hour, day]);//רשימה של קורסים עם כיתה משובצת לכל קורס
                }
                CourseToKita = new Dictionary<string, string>() { };
            }
            return Ctt;
        }

        public static List<Course> AssignClasses(List<Course> courses)//הפעולה מחזירה רשימה של קורסים(בשעה מסוימת ביום מסוים) עם כיתה משובצת לכל קורס
        {
            if (courses == null)//עם לא קיים קורס באותה שעה באותו יום, נחזיר רשימה ריקה
            {
                CourseToKita = new Dictionary<string, string>() { };//מאפס את הרשימה של הקורסים מהשיעור הקודם
                return new List<Course>();
            }


            Dictionary<string, string> Cp = new Dictionary<string, string>();//רשימה מעודכנת של הקורסים
            foreach (Course course in courses)
            {
                string output;
                if (CourseToKita.TryGetValue(course.GetCourseN(), out output))//אם יש חזרה על קורסים ברצף
                {
                    course.SetKita(output);
                    Cp.Add(course.GetCourseN(), output);//מכניס שם קורס וכיתה טפוסה
                }
            }
            CourseToKita = Cp;
            foreach (Course course in courses)
            {
                if (CourseToKita.ContainsKey(course.GetCourseN()))//אם יש קורסים על גבי מספר שיעורים ברצף תדלג על שלב התאמת הכיתה
                {
                    continue;
                }
               
                int minStudents = 1000;
                string bestKita = "";

                for (int i = 0; i < kitaList.Length; i++)
                {
                    if (!CourseToKita.ContainsValue(kitaList[i].GetName()))
                    {
                        if (kitaList[i].GetSize() >= course.GetStuNum())
                        {
                            if (kitaList[i].GetSize() <= minStudents)
                            {
                                bestKita = kitaList[i].GetName();
                                minStudents = kitaList[i].GetSize();

                            }
                        }
                    }
                }

                //אם לא נמצאה כיתה עם מספיק מקומות לקורס אז תיבחר הכיתה הפנויה עם מספר המקומות הגדול ביותר
                if (bestKita == "")
                {
                    int maxCapacity = 0;
                    for (int i = 0; i < kitaList.Length; i++)
                    {
                        if (!CourseToKita.ContainsValue(kitaList[i].GetName()))
                        {
                            if (kitaList[i].GetSize() > maxCapacity)
                            {
                                maxCapacity = kitaList[i].GetSize();
                                bestKita = kitaList[i].GetName();
                            }
                        }
                    }
                }

                course.SetKita(bestKita);
                CourseToKita.Add(course.GetCourseN(), bestKita);
            }
            return courses;
        }


    }
    class Kita
    {
        private string name;
        private int size;
        public Kita(string name, int size)
        {
            this.name = name;
            this.size = size;
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetSize()
        {
            return this.size;
        }

    }
    class Course
    {
        private int studentNum;
        private string teacher;
        private string courseName;
        private string kitaNum ;
        public Course(int studentNum, string teacher, string courseName)
        {
            this.studentNum = studentNum;
            this.teacher = teacher;
            this.courseName = courseName;
        }
        public int GetStuNum()
        {
            return this.studentNum;
        }
        public string GetTeacher()
        {
            return this.teacher;
        }
        public string GetCourseN()
        {
            return this.courseName;
        }
        public string GetKita()
        {
            return this.kitaNum;
        }
        public void SetKita(string kita)
        {
            this.kitaNum = kita;
        }

    }

}
