

using System.Diagnostics.CodeAnalysis;

class program
{
    static void Main()
    {
        //Student s1 = new Student()
        //{ RollNumber = 1, Name = "Pooja", city = "Yavatma", Gender = "Male" };

        ////List<Student> students = new List<Student>();
        //students.Add(s1);
        //students.Add(new Student()
        //{
        //    RollNumber = 2,
        //    Name = "nisha",
        //    city = "pune",
        //    Gender = "Female"
        //});
        //students.Add(new Student()
        //{ RollNumber = 3, Name = " Ganaga", city = " Yavatmal", Gender = " Male" });
        //foreach (Student item in students)
        //{
        //    Console.WriteLine($" RollNumber : {item.RollNumber} , Name : {item.Name} , City : {item.city} , Gender : {item.Gender}");

        //}


        //List<Student> students = new List<Student>()
        //{
        //   new Student () {RollNumber = 1, Name = " Pooaja" , city = "yavatmal" , Gender = "Female" },
        //   new Student () {RollNumber = 2, Name = " naina" , city = "yavatmal" , Gender = "Female" },
        //   new Student () {RollNumber = 3, Name = " Sanj" , city = "Mumabai" , Gender = "male" },
        //   new Student () {RollNumber = 4, Name = " Sawali" , city = "Pune" , Gender = "male" }


        //};


        // foreach (Student item in students )
        //{
        //    Console.WriteLine($" RollNumber : {item.RollNumber}" +
        //        $" Name : {item.Name} City : {item.city} , Gender : {item.Gender}");
        //}
        // Student s2 = new Student()
        // {
        //     RollNumber = 5, Name = "Babit", Gender = " Male", city = " pune"
        // };

        //if (students.Contains(s1, new StudentHelper()))
        //{

        //    Console.WriteLine(" Exists");
        //}
        //else
        //{
        //    Console.WriteLine("not Exists");
        //}

        Student s1 = new Student() { RollNumber = 1, Name = " Pooaja", city = "yavatmal", Gender = "Female" };
        Student s2 = new Student() { RollNumber = 2, Name = " naina", city = "yavatmal", Gender = "Female" };
        Student s3 = new Student() { RollNumber = 3, Name = " Sanj", city = "Mumabai", Gender = "male" };
        Student s4 = new Student() { RollNumber = 4, Name = " Sawali", city = "Pune", Gender = "male" } ;

        Dictionary<int, Student> students = new Dictionary<int, Student>();
        students.Add(s1.RollNumber, s1);
        students.Add(s2.RollNumber, s2);
        students.Add(s3.RollNumber, s3);
        foreach (var item in students)
        {
            var value = item.Value;
            Console.WriteLine($" Key : {item.Key} ");
            Console.WriteLine($" RollNumber : {value.RollNumber} " + 
                $" Name : {value.Name} , Gender : {value.Gender}" + 
                $" City : {value.city}");

        }
        Student s = students[2];
        Console.WriteLine($" RollNumber : {s.RollNumber} " +
            $" Name : {s.Name} , Gender : {s.Gender} , City : {s.city}");


   
        Console.ReadLine();

    }
}
class Student
{


    public int RollNumber { get; set; }
    public string Name { get; set; }

    public string Gender { get; set; }

    public string city { get; set; }

    public override bool Equals(object? obj)
    {
        Student s = (Student)obj;
        return this.RollNumber.Equals(s.RollNumber) && this.Name.Equals(s.Name) && this.city.Equals(s.city)
            && this.Gender.Equals(s.Gender);
    }
}

class StudentHelper : IEqualityComparer< Student>
{ 
    public bool Equals(Student? x,Student?y)
    {
        return x.RollNumber.Equals(y.RollNumber) &&
            x.Name.Equals(y.Name) &&
            x.Gender.Equals(y.Gender) &&
            x.city.Equals(y.city);
    }

    public int GetHashCode([DisallowNull] Student obj)
    {
        return obj.RollNumber.GetHashCode() ^ obj.Name.GetHashCode() ^
            obj.Gender.GetHashCode() ^ obj.city.GetHashCode();
    }

}