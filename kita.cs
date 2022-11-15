class Kita
{
    //pindex powered code
    public string kita_Name { get; set; }
    public int kita_Size { get; set; }

    public Kita(string name, int size)
    {
        kita_Name = name;
        kita_Size = size;
    }
    public bool DoesItFit(int kita_Size, int studentSize)
    {
        if (kita_Size >= studentSize)
            return true;
        else
            return false;
    }
    public void Reserve(string kita_name,Courses course_name,DateTime required_course_time)
    {
        if (isAvailable(kita_name, required_course_time) == true)
        {
            timetable.insert(kita_name, course_name, required_course_time);
        }
    }
    
    public bool isAvailable(string kita_name,DateTime required_course_time)
    {

        if (timetable.required_course_time== null)
        {
            return true;
        }
        return false;
    }


    //לדאוג שהחדר מתאים למספר התלמידים הרצוי באותו הרגע
    // פונקציה האם החדר פנוי
    // פונקציה אשר שומרת את החדר לקורס מסויים
    //לשייך כיתה וגודלה
    //האם החדר פנוי לזמן מסויים
};