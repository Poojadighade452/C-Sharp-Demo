
class program
{
    static void Main()
    {

        //string[] names = new string[] { "vishal", " Mahesh", " Shital", " Sheha" };
        //string n = names[1];
        //Console.WriteLine(names[3]); // Sheha

        //names[2] = " Himmat";
        //n = names[2];
        //Console.WriteLine(n); // Himmat
        Student[] students = new Student[]
        {
            new Student(){ RollNumber = 101 , Name ="visha",city = " Pune" },
             new Student(){ RollNumber = 102 , Name ="Damini",city = " mumbai" },
            new Student(){ RollNumber = 103 , Name ="Kiran",city = " aurangabad" },
            new Student(){ RollNumber = 104 , Name ="Rekha",city = " nagpur" },
            new Student(){ RollNumber = 105 , Name ="Shevant",city = " mumbai" },
            new Student(){ RollNumber = 106 , Name ="warsha",city = " Pune" },
        };

        Institute i1 = new Institute(students);
        string name = i1[102];// reading values
        Console.WriteLine(name);// Damini

        i1[105] = " Prajakta";// setting value

        name = i1[105];// reading values
        Console.WriteLine(name);// prajakta

        Student s = i1["Rekha"];


        Console.WriteLine($" {s.Name} : {s.RollNumber} ");


















        Console.ReadLine();



    }
}
class Student
{



    public int RollNumber { get; set; }
    public string Name { get; set; }
    public string city { get; set; }

}
class Institute
{

    public string InstituteName { get; set; }
    private Student[] _students;


    public Institute(Student[] students)

    {

        _students = students;
    }
   public string this[int rn]
    {
         get
       
        {
            for (int i = 0; i < _students .Length; i++)
            {
                if (_students[i].RollNumber == rn)
                {
                    return _students[i].Name;
                }
            }
            return $" Student Not Fount by Roll Number {rn}";
        }
         
        set
        {
            for (int i =0; i< _students.Length; i++)
            {
                if (_students[i].RollNumber == rn)
                {
                    _students[i].Name = value;
                }
            } 

        }  

        

    }
     public Student this[string name]
    {
        get
        {
            for (int i = 0; i<_students.Length; i++)
            {
                if (_students[i].Name == name)
                {
                    return _students[i];
                }
                
            }
            return null;
        }
    }

}  

