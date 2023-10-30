using System.Diagnostics.CodeAnalysis;
using System.Linq;



class program
{
    static void Main()
    {

        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var result = numbers.Count();
        Console.WriteLine(result);

        result = numbers.Count(i => i % 2 == 0);
        Console.WriteLine(result);

        result = (int)numbers.LongCount();
        Console.WriteLine(result);


        result = numbers.Max();
        Console.WriteLine(result);

        result = numbers.Min();
        Console.WriteLine(result);

        result = numbers.Sum();
        Console.WriteLine(result);

        result = (int)numbers.Average();
        Console.WriteLine(result);



        bool b1 = numbers.Contains(5);
        Console.WriteLine(b1);


        List<Student> students = new List<Student>()
        {
            new Student () { RollNumber = 1,  Name = " Pooja" , City = " Yavatmal", Age =20},
           new Student() { RollNumber = 2, Name = " Durga", City = " Yavatmal", Age = 25 },
            new Student () { RollNumber = 3,  Name = " Surbhi" , City = " Nanded",Age = 23 },
            new Student () { RollNumber = 4,  Name = " Naina" , City = " Pune" , Age =56 },
            new Student () { RollNumber = 5,  Name = " Prema" , City = " Delhi" , Age = 26 } ,
            new Student () { RollNumber = 6,  Name = " sunanda" , City = " Pune" ,  Age =34 }


        };
        Student s1 = new Student()
        {
            RollNumber = 1,
            Name = " Pooja",
            Age = 28,
            City = "nashik"
        };

        //b1 = students.Contains(s1);
        //Console.WriteLine(b1);

        //b1 = students.Contains(s1, new StudentHelper());
        //Console.WriteLine(b1);

        b1 = numbers.All(i =>  i> 0);
        Console.WriteLine(b1);


        b1 = numbers.Any(i => i > 0);
        Console.WriteLine(b1);


            


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
class StudentHelper : Student
{
    public bool Equals(Student? X, Student? y)
    {
        return X.RollNumber.Equals(y.RollNumber) && X.Name.Equals(y.Name)
            && X.City.Equals(y.City) && X.Age.Equals(y.Age);
    }
    public int GetHashcode([DisallowNull] Student obj)
    {
        return obj.RollNumber.GetHashCode() ^
            obj.Name.GetHashCode() ^
            obj.City.GetHashCode() ^
            obj.Age.GetHashCode();
    }

}