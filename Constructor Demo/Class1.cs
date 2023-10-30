class student
{
    public string  FirstName;
    public string  LastName;
    public static string courseName = "dot net";
    public student()
    {
        Console.WriteLine($"Constuctor Called");
        FirstName = "pooja";
        LastName = "dighade";
    }

    public void PrintFullName()
    {
        Console.WriteLine($" Full name - {FirstName}, {LastName}");
    }

    //public void Initialize(string fn,string ln)

    //{
    //    firstname = fn;
    //    LastName = ln;
    //}

    static student ()
    {
        courseName = "dot net";
        Console.WriteLine($" static Student () called ");
    }


      //parameterized Constructor
    public student (string FirstName, string LastName)
    {
       this.FirstName = FirstName;
        this.LastName = LastName;
    }

    // parameterized constructor = copy constructor
    public student (student s)
    {

       FirstName = s.FirstName;
         LastName =  s.LastName;
    }
}


    
    
 