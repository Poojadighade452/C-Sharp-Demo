

using System.Linq;
class program
    {
        static void Main()
        {

            List<Student> students = new List<Student>()
     {
         new Student () { RollNumber = 1,  Name = " Pooja" , City = " Yavatmal"},
         new Student () { RollNumber = 2,  Name = " Durga" , City = " Yavatmal"},
         new Student () { RollNumber = 3,  Name = " Surbhi" , City = " Nanded"},
         new Student () { RollNumber = 4,  Name = " Naina" , City = " Pune"},
         new Student () { RollNumber = 5,  Name = " Prema" , City = " Delhi"},
         new Student () { RollNumber = 6,  Name = " sunanda" , City = " Pune"},


     };
            Console.WriteLine($" ***** All Student **************");
            foreach (var item in students)
            {
                Console.WriteLine($" RollNUmber : {item.RollNumber} " +
                    $" Name : {item.Name} , City : {item.City}");
            }


            Console.WriteLine($" ************** Pune Student ***************");
        var PuneStudents = from s in students
                           where s.City == "Pune"
                           select s;

        foreach (var item in PuneStudents)
        {
            Console.WriteLine($" RollNUmber : {item.RollNumber} " +
                $" Name : {item.Name} , City : {item.City}");
        }
        Console.WriteLine();
        //foreach (var item in PuneStudents)
        //{
        //    Console.WriteLine($" RollNumber : {item.RollNumber}  Name : {item.Name}  city : { item.City} ");
        //}

        var YavatmalStudents = students.Where(S => S.City == "Yavatmal");

            foreach (var item in YavatmalStudents)
            {
                Console.WriteLine($" RollNumber : {item.RollNumber}  Name : {item.Name}  city : {item.City} ");
            }

            Console.WriteLine($" ************* Students Name Start with P ***********");
            var PnameStart = from P in students
                             where P.Name.StartsWith("P")
                             select P;
            foreach (var item in PnameStart)
            {
                Console.WriteLine($" RollName : {item.RollNumber}" +
                    $" Name : {item.Name} city : {item.City}");
            }

            Console.ReadLine();
        }
















    }
    class Student
    {

        public int RollNumber { get; set; }
        public string ?Name { get; set; }

        public string? City  { get; set; }






    }
