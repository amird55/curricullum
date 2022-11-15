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
    private Course [][] createTimeTable(Course[] courseArray, int timeTableRows=5, int timeTableCols=6)
    { // Returns a timetable with all given courses placed
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
    private Course [][] placeCourse(Course [][] timeTable, Course c1)
    { // Places given course c1 into timeTable and returns timeTable

    }
    private int [][] availableHours(Course [][] timeTable, Course c1)
    { // Returns a 2d array of 1's and 0's. 1 = A course can be placed this hour, 0 = A course can't be placed at this hour
        int [][] availableHours = new int [timeTable.GetLength(0)][timeTable.GetLength(1)];
        
        for (int i=0; i<grades.Length;i++)
        {
            for (int j=0; j<grades.Length;j++)
            {
                if (timeTable[i][j] != null || c1.teacher.hours[i][j] == 0)
                { // if there is a different course or if teacher is not available
                    availableHours[i][j] = 0;
                    continue;
                }
                availableHours[i][j] = 1; // Assuming a course can be placed
                for (int x=0;x<c1.students.Length;x++)
                { // Iterating on student array
                    if (c1.students[x].hours[i][j] == 0)
                    { // If a student is not available
                        availableHours[i][j] = 0;
                    }
                }
            }
        }
        return availableHours;
        }
}