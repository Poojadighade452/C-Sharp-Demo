using System.Globalization;
using System.Linq;
class program
{
    static void Main()
    {

        #region simple type collection
        //List<int> numbers = new List<int>() { 1, 45, 78, 659, 45, 79, 69, 54, 235, 8956, 8964 };
        //Console.WriteLine($"********** All Items **************");


        //foreach (int num in numbers)
        //{
        //    Console.Write($" {num} ");
        //}
        //Console.WriteLine();

        //numbers.Reverse();
        //Console.WriteLine($" ******** all items revers in numbers ************");
        //foreach (int num in numbers)
        //{
        //    Console.Write($" {num} ");
        //}
        //Console.WriteLine();
        //Console.WriteLine($" All items AfterOrder bY (i => i *********** ");
        //IOrderedEnumerable<int> result = numbers.OrderBy(i => i);
        //foreach (int num in result)
        //{
        //    Console.Write($" {num} ");
        //}


        //Console.WriteLine();
        //IOrderedEnumerable<int> result1 = numbers.OrderByDescending(i => i);
        //foreach (int num in result1)
        //{
        //    Console.Write($" {num} ");
        //}

        //Console.WriteLine();
        #endregion simple type collection


        List<Student> students = new List<Student>()
        {
            new Student () { RollNumber = 1,  Name = " Pooja" , City = " Yavatmal", Age =20},
           new Student() { RollNumber = 2, Name = " Durga", City = " Yavatmal", Age = 25 },
            new Student () { RollNumber = 3,  Name = " Surbhi" , City = " Nanded",Age = 23 },
            new Student () { RollNumber = 4,  Name = " Naina" , City = " Pune" , Age =56 },
            new Student () { RollNumber = 5,  Name = " Prema" , City = " Delhi" , Age = 26 } ,
            new Student () { RollNumber = 6,  Name = " sunanda" , City = " Pune" ,  Age =34 }


        };
        //Console.WriteLine($" ***** All Student **************");
        //   foreach (var s in students)
        //   {
        //       Console.WriteLine($" RollNUmber : {s.RollNumber} " +
        //           $" Name : {s.Name} , City : {s.City} Age : {s.Age} ");
        //   }

        //   Console.WriteLine($" all item after orderBy s=> s.city**********");
        //   var result = students.OrderBy(s => s.City);

        //   foreach (Student s in result  )
        //   {
        //       Console.WriteLine($" RollNUmber : {s.RollNumber} " +
        //          $" Name : {s.Name} , City : {s.City}  age : {s.Age}");
        //   }
        //   Console.WriteLine();
        //   Console.WriteLine($" ************* All items after orderby (s => s.city ) ******* ");

        //   var result2 = students .OrderBy (s=> s.City).ThenBy(s => s.Name);
        //   foreach (Student s in result2)
        //   {
        ////       Console.WriteLine($" RollNumber : {s.RollNumber} , Name : {s.Name} , city  : {s.City} , Age : {s.Age} ");


        //   },

        //List<int> numbers = new List<int>() { 45, 85, 75, 46, 21, 78 };
        //numbers.Sort();
        //foreach (int num in numbers)

        //{
        //    Console.Write($" {num}");

        // }
        //Console.WriteLine();

        //List<string> names = new List<string>()
        //  {
        //      "vishal" , "gita" , "Shital", "pooja"
        //  };
        //  names.Sort();
        //foreach (string name in names)
        //{
        //    Console.Write($"{name} ");

        //}

        //Console.WriteLine($" ********** All items after sort *********** ");
        //students.Sort();
        //foreach (Student s in students ) 
        //{
        //    Console.Write($" RollNumber : {s.RollNumber} , Name : {s.Name} , city : {s.City}, Age : {s.Age} ");

        //}
        //Console.WriteLine();

        students.Sort(0, 3, new studentHelper());
        Console.WriteLine($"******** All Items After Sort (new StudentHelpeprs())) *********");
        foreach (Student s in students)
        {
            Console.WriteLine($"Rollnumber : {s.RollNumber} , name :{s.Name} ,city : {s.City},Age : {s.Age} ");
        }


        students.Sort((x, y) => x.City.CompareTo(y.City));

        foreach (Student s in students)
        {

            Console.WriteLine($" Rollnumber :{s.RollNumber} , name : {s.Name} , city : {s.City} , age : {s.Age}" );
        }
        Console.ReadLine();
    }


}
class Student : IComparable
{
   
    

        public int RollNumber { get; set; }
        public string? Name { get; set; }

        public string? City { get; set; }

        public int Age { get; set; }



    public int CompareTo(object? obj)
    {
        Student s = obj as Student;
        //if(this.Age > s.Age)
        //{
        //    return 1;

        //}
        //else if (this .Age < s.Age)
        //{
        //    return -1;

        //}
        //else
        //{
        //    return 0;
        //}


        return this.Age.CompareTo(s.Age);






    }
    


}
class studentHelper : IComparer <Student>
{
  public int CompareTo(Student?x,Student?y)
    {
        return x.Name.CompareTo(y.Name);
    }

    int IComparer<Student>.Compare(Student? x, Student? y)
    {
        return x.Name.CompareTo(y.Name);
    }
}