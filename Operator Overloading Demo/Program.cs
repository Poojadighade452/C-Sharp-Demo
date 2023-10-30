
using System.Runtime.Intrinsics.X86;

class program
{


    static void Main()
    {

        int a = 50;
        int b = 20;
        if (a == b)
        {

            Console.WriteLine($" a & b are Equal");

        }
        else
        {
            Console.WriteLine($" a &  b are not Equal");

        }
        string ss1 = ("pooja");
        string ss2 = ("demat ");
        string ss4 = (" akash");
        string ss5 = (" pooja ");

        string ss3 = ss1 + ss2;
        Console.WriteLine(ss3);

        string ss6 = ss5 + ss4;
        Console.WriteLine(ss6);

        if (ss1 == ss2)
        {

            Console.WriteLine($" ss1 & ss2 are Equal");

        }

        else
        {
            Console.WriteLine($" ss1 & ss2 are not Equal");
        }



        //Student s1 = new Student(" pooja", "dighade");
        //Student s2 = new Student(" pooja", " digad");
        Student s1 = new Student("hema", " devogoda");
        Student s2 = new Student(" baskar", " nagtode");
        //Student s3 = new Student(" pooja", " dighade");
        //Student s4 = new Student(" pooja", " dighade");

        Student s3 = s1 + s2;
        Console.WriteLine($" { s3. FirstName} , {s3.LastName}");

        if (s1 == s2)
        {

            Console.WriteLine($" s1 & s2 are Equal");

        }

        else
        {
            Console.WriteLine($" s1 & s2 are not Equal");
        }


        Console.ReadLine();
    }

}

class Student
{

    public string FirstName;
    public string LastName;

    public Student(string fn, string ln)
    {

        FirstName = fn;
        LastName = ln;
    }
    public static bool operator ==(Student s1, Student s2)
    {
        return s1.FirstName == s2.FirstName && s1.LastName == s2.LastName;

    }

    public static bool operator !=(Student s1, Student s2)
    {
        return s1.FirstName != s2.FirstName && s1.LastName != s2.LastName;

    }
     public static Student operator + ( Student s1, Student s2)
    {
        Student s = new Student(
        s1.FirstName + " , " + s2.FirstName,
            s1.LastName + " ," + s2.LastName);
        return s;
    }

}


























