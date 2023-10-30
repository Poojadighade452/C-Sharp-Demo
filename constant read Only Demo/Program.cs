
using static System.Console;

class program
{
     static void Main()
    {
        //WriteLine(student.CourseName);

        student s1 = new student();
        s1.FirstName = " pooja";
        s1.LastName = " dighade";
        /*s1.CourseName = " dot net"*/;
        s1.Print();
        //student.CourseName = " java";

       student s2 = new student();
        s2.FirstName = " anil";
        s2.LastName = " rathod";
        //s2.CourseName = " dot net";
        s2.Print();


        Console.ReadLine();
    }



}

class student
{
    public string FirstName;
    public string LastName;
    //public  static string CourseName = " dot net";
    //public const string CourseName = " dot net";
    //public readonly string CourseName = " dot net";
    public static readonly string CourseName = " dot Net";

    //public student()
    //{
    //    CourseName = " java";
    //}
    public void Print()
    {


        WriteLine($" {CourseName}  : {FirstName}, {LastName}");
    }



}