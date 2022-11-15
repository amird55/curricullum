using system;
class calculation{
    Course[] courseArray; // Array of all Courses which we need to place

    public float courseGrade(Course c1/*, Teacher t1 */)
    { // Greater return vlaue = The course is harder to place
        Teacher t1 = c1.teacher;
        int deltaHours = t1.AvailableHours-c1.mDuration;
        return deltaHours*-0.5 + c1.LastYearStudent*0.4 + c1.FirstYearStudent*0.1;
    }
    
    private float [] courseGrading(Course[] courseArray)
    { // Given an array of courses, grades each course by its flexibility
        float [] grades = new float[courseArray.Length]; // Array of floats which represents the flexibility grade of each course
        for (int i=0;i<courseArray.Length;i++)
        {
            grades[i] = courseGrade(courseArray[i]); // Grading the flexibility of a course in courseArray[i]
        }
        return grades;
    }
    private float [][] createTimeTable(Course[] courseArray, int timeTableRows=5, int timeTableCols=6)
    {
        Course [][] timeTable = new float [timeTableRows][timeTableCols]; // The final timetable
        float [] grades = courseGrading(courseArray); // Grading every course
        float maxNum=-99;
        int maxIndex=0;
        for (int i=0; i<grades.Length;i++)
        {
            for (int j=0; j<grades.Length;j++)
            {
                if (grades[j] > maxNum)
                {
                    maxNum = grades[j];
                    maxIndex = j;
                }
            }
            grades[maxIndex] = -99;
            timeTable = placeCourse(timeTable, courseArray[maxIndex]);
        }

    }
    private float [][] placeCourse(Course [][] timeTable, Course c1)
    {

    }
}