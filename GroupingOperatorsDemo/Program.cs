class program
{
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
        Console.WriteLine($" ********** All Items *********** ");
        foreach (Student s in students)
        {
            Console.WriteLine($" Rollnumber : {s.RollNumber} Name : {s.Name} , City : {s.City} Age : {s.Age} ");
        }
        //var result = students.GroupBy(s => s.Age);
        var result = from s in students
                     group s by s.City;

        foreach (var item in result)
        {
            Console.WriteLine($" {item.Key} : {item.Count()} ");
        }
        Console.WriteLine();
        //var result1= students.Take(2);
        //Console.WriteLine($" *********** All item After Take(2 ) ****** ");
        //foreach (Student s in result1)
        //{
        //    Console.WriteLine($" RollNumber : {s.RollNumber} , Name : {s.Name} , City : {s.City} , age : {s.Age} ");
        //}
        var result1 = students.Skip(2);
        Console.WriteLine($" ************ all Items After take (2) ***** ");
        foreach (Student s in result1)
        {
            
             Console.WriteLine($" RollNumber : {s.RollNumber} , Name : {s.Name} , City : {s.City} , age : {s.Age} ");
           
        }


        Console.ReadLine();
    }

}
class Student
{



    public int RollNumber { get; set; }
    public string? Name { get; set; }

    public string? City { get; set; }

    public int Age { get; set; }



}