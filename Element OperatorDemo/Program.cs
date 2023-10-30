using System.Linq;

class program
{
    private static object console;

    static void Main()
    {


        List<Student> students = new List<Student>()
        {
            new Student () { RollNumber = 1,  Name = " Pooja" , City = " Yavatmal", Age =20},
           new Student() { RollNumber = 2, Name = " Durga", City = " Yavatmal", Age = 25 },
            new Student () { RollNumber = 3,  Name = " Surbhi" , City = " Nanded",Age = 23 },
            new Student () { RollNumber = 4,  Name = " Naina" , City = " Pune" , Age =56 },
            new Student () { RollNumber = 5,  Name = " Prema" , City = " Delhi" , Age = 26 } ,
            new Student () { RollNumber = 6,  Name = " sunanda" , City = " Pune" ,  Age =34 }


        };

        Console.WriteLine($" ************ All Students ********* ");
        foreach (var item in students)
        {
            Console.WriteLine($" rollNumber : {item.RollNumber} , Name : {item.Name} , City : {item.City} , Age : {item.Age} ");

        }
        // ElementAt - it return item from given index 
        // throws exception if index goind outside of size

        //Student i = students.ElementAt(2);
        //    Console.WriteLine($" Rollnumber  : {i.RollNumber} , Name : {i.Name} , city : {i.City} , Age : {i.Age} ");


        // it handles the exception and return and returns default value
        // this exception : throw exception if index goin outside of size
        //Student i = students.ElementAtOrDefault(10);
        //if(i is not null)
        //{
        //    Console.WriteLine($" Rollnumber  : {i.RollNumber} , Name : {i.Name} , city : {i.City} , Age : {i.Age} ");


        //}

        //Student i = students.First();
        //Console.WriteLine($" Rollnumber  : {i.RollNumber} , Name : {i.Name} , city : {i.City} , Age : {i.Age} ");


        // Student i = students.First(s=> s.Name.StartsWith("D") );
        //Console.WriteLine($" Rollnumber  : {i.RollNumber} , Name : {i.Name} , city : {i.City} , Age : {i.Age} ");


        // FirstOrDefalut() - returns first matching item from given collectio n 
        // ot jamdles exception and returns Default values
        // this exception : throws exception if no matching item from given collections

        // Student i = students.FirstOrDefault(s=> s.Name.StartsWith("y") );
        //Console.WriteLine($" Rollnumber  : {i.RollNumber} , Name : {i.Name} , city : {i.City} , Age : {i.Age} ");


        Student i1 = students.Last();
        Console.WriteLine($" Rollnumber  : {i1.RollNumber} , Name : {i1.Name} , city : {i1.City} , Age : {i1.Age} ");


        // Student i2 = students.LastOrDefault(s=> s.Name.StartsWith("P") );
        //Console.WriteLine($" RollNumber  : {i2.RollNumber} , Name : {i2.Name} , City : {i2.City} , Age : {i2.Age} ");


        Student i2 = students.Single(s => s.City.StartsWith("Y"));
        Console.WriteLine($" RollNumber  : {i2.RollNumber} , Name : {i2.Name} , City : {i2.City} , Age : {i2.Age} ");



        Console.ReadLine();

    }



   
}
class Student
{



    public int RollNumber { get; set; }
    public string ?Name { get; set; }

    public string  ?City { get; set; }

    public int Age { get; set; }


}
