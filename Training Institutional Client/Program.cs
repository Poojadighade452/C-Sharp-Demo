using System.Diagnostics;
using System.Net.Http.Headers;
delegate void Delegate1();
delegate void delegates2(string s1, string s2 );
delegate int delegates3(string s);

class program
{
    static void Main()
    {
        //Delegate1 d1 = delegate ()
        //{
        //    Console.WriteLine("delegate1");
        //};

        //d1();

        //delegates2 d2 = delegate (string s1, string s2)
        //{
        //    Console.WriteLine($"{s2}, {s1} ");
        //};
        //d2( "hemat", "dosale");

        //delegates3 d3 = delegate (string s)
        //{
        //    Console.WriteLine("Delegates3");
        //    return s.Length;
        //};
        //int result = d3("pooja");
        //    Console.WriteLine(result);

        Student[] students = new Student[]
        {
            new Student(){ RollNumber = 1, Name = "vishal" , City= "Pune"},
            new Student(){ RollNumber = 2, Name = "Shital" , City= "Pune"},
            new Student(){ RollNumber = 3, Name = "Divya" , City= "Mumbai"},
            new Student(){ RollNumber = 4, Name = "Monika" , City= "Nashik"},
            new Student(){ RollNumber = 5, Name = "Prashant" , City= "Pune"},
            new Student(){ RollNumber = 6, Name = "Gajanan" , City= "Mumbai"},

         };

        ////Institute seed = new Institute("SEED INFOTECH",students);
        //seed.InstituteDetails();
        //Console.WriteLine();
        Institute
        cdac = new Institute("CDAC", students);
        //cdac.InstituteDetails();
        //cdac.AllStudents();
        ////cdac.DiscountStudents();

        //DiscountCriteria del1 = SeedDiscountCriteria;
        //        cdac.cdacDiscountStudents(del1);

        //DiscountCriteria del1 = delegate (Student s)
        //{
        //    return s.City.Equals("Mumbai");
        //};
        //cdac.cdacDiscountStudents(del1);

        //DiscountCriteria del = s => s.City.Equals("Pune");
        //cdac.cdacDiscountStudents(del);

        DiscountCriteria del = s => s.Name.Equals("S");
        cdac.cdacDiscountStudents(del);






        Console.ReadLine();
    }

    //static bool SeedDiscountCriteria(Student s)
    //{
    //    return s.Name.StartsWith("S");
    //}
       
    //static bool cdacDiscountCriteria(Student s)
    //{
    //    return s.City.Equals("Pune");
    //}


}
