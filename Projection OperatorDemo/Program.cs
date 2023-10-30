using System.Linq;

List<Student> students = new List<Student>()
        {
            new Student () { RollNumber = 1,  Name = " Pooja" , City = " Yavatmal", Age =20, subject = new List<string >(){ "s1" , "s2 "}  },
           new Student() { RollNumber = 2, Name = " Durga", City = " Yavatmal", Age = 25 ,subject = new List<string >(){ "s6" , "s4 "}, },
            new Student () { RollNumber = 3,  Name = " Surbhi" , City = " Nanded",Age = 23,subject = new List<string>() { "s5", "s3 " } },
            new Student () { RollNumber = 4,  Name = " Naina" , City = " Pune" , Age = 56, subject = new List<string>() { "s6", "s4" }  },
            new Student () { RollNumber = 5,  Name = " Prema" , City = " Delhi" , Age = 26,subject = new List<string>() { "s8",  "s1" }  },
            new Student () { RollNumber = 6,  Name = " sunanda" , City = " Pune" ,  Age = 34 ,subject = new List<string>() { "s8",  "s7 " }  }


        };

//IEnumerable<List<string>> SubjectStudents = students.Select(s => s.subject);
//foreach (var subjects in SubjectStudents)
//{
//    foreach (var sub in subjects)
//    {
//        Console.Write($" {sub} ");
//    }

//}


//IEnumerable<string> studentSubjects = students.SelectMany(s => s.subject);
//foreach (var subjects in studentSubjects)
//{
//    Console.Write(subjects);
//}


//Console.WriteLine("please enter comma separated names");
//string input = Console.ReadLine();
//string[] inputs = input.Split(  );
//foreach (string i in inputs) 
//{
//    Console.WriteLine(i);
//}

//inputs.GroupBy(s => s);












Console.ReadLine();
//List<Student> students = new List<Student>()
//{
//    new Student () { RollNumber = 1,  Name = " Pooja" , City = " Yavatmal", Age =20},
//   new Student() { RollNumber = 2, Name = " Durga", City = " Yavatmal", Age = 25 },
//    new Student () { RollNumber = 3,  Name = " Surbhi" , City = " Nanded",Age = 23 },
//    new Student () { RollNumber = 4,  Name = " Naina" , City = " Pune" , Age =56 },
//    new Student () { RollNumber = 5,  Name = " Prema" , City = " Delhi" , Age = 26 } ,
//    new Student () { RollNumber = 6,  Name = " sunanda" , City = " Pune" ,  Age =34 }


//};
//Console.WriteLine($" ****** All Items ********** ");
//foreach (Student s in students)
//{
//    Console.WriteLine($" RollNumber : {s.RollNumber} Name : {s.Name} , City : {s.City} Age : {s.Age} ");
//}

//IEnumerable<string> names = students.Select(s => s.Name);
//foreach (string name in names)
//{
//    Console.Write($" {name} ");



//}
//Console.WriteLine();
//var result = students.Select(s => new { Name = s.Name, city = s.City });
//foreach (var item in result)
//{
//    Console.Write($" {item.Name} {item.city} ");

//}

//IEnumerable<Person> result1= students.
//    Select(s => new Person() { Name = s.Name, city = s.City });

//foreach (var item in result1)
//{
//    Console.WriteLine($" {item.Name} : {item.city}");

//}
//Console.WriteLine();

//List<string> personNames = new List<string>()
//{ "Akash" , "Babita" , "chinu" , "Nunu" , "Pooja"  };
//IEnumerable<Person> persons = personNames.Select(s => new Person() { Name = s });
//foreach (var p in persons)
//{
//    Console.WriteLine($" {p.Name}");
//}











class Student
{



    public int RollNumber { get; set; }
    public string? Name { get; set; }

    public string? City { get; set; }

    public int Age { get; set; }

    public List<string> subject { get; set; }

}
class Person
{
    public string?Name { get; set; }
    public string?city { get; set; }
}