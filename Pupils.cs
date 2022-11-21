class Pupil
  {
 //תכונות תלמיד
    private string firstName;
    private string lastName;
    private int id;
    private int age;

    private bool isLastYear;


  public Pupil() //בנאי 
  {
    this.firstName = Rami;
    this.lastName = Cohen;
    this.id = 4628;
    this.age = 20:

    this.isLastYear = true;
  }

 public Pupil(string fName, string lName, int id, int age, bool isLastYear)
 {
    this.firstName=fName;
    this.lastName=lName;
    this.id=id;
    this.age=age;

    this.isLastYear=isLastYear;
 }

 public Pupil(Pupil p) //בנאי מעתיק
 {
    this.firstName = p.firstName;
    this.lastName = p.lastName;
    this.id = p.id;
    this.age = p.age;

    this.isLastYear = p.isLastYear;
 }

//to string - הדפסה
public string toString()
{
    return "firstName = " + this.firstName + \n +
            "lastName = " + this.lastName

}



//getters & Setters

//First Name
    public int getFirstName()
    {
        return this.firstName;
    }
    public int setFirstName(int name)
    {
        this.firstName = name;
    }

//Last Name
    public int getLastName()
    {
        return this.lastName;
    }
    public int setLastName(int name)
    {
        this.lastName = name;
    }

//ID
        public int getId()
    {
        return this.id;
    }
    public int setId(int value)
    {
        this.id = value;
    }

//Age 
        public int getAge()
    {
        return this.age;
    }
    public int setAge(int value)
    {
        this.age = value;
    }

//Is Last Year?
        public int getIsLastYear()
    {
        return this.isLastYear;
    }
    public int setIsLastYear(int answer)
    {
        this.isLastYear = answer;
    }
  }