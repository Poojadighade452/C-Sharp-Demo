using Object_Type_Demo;

class Program

{


    static void Main()
    {
        #region ToString(), GetType()
        object o1 = true;
        o1 = 10;
        o1 = " pooja";
        o1 = new student("pooja", " dighade");


        bool b1 = true;
        Console.WriteLine(b1.ToString()); // true
        Type bt1 = b1.GetType();
        //Console.WriteLine(bt1.FullName);
        //Console.WriteLine(bt1.GetType().Name);

        int i1 = 100;
        Console.WriteLine(i1.ToString()); // 100
        Console.WriteLine(i1.GetType().Name);

        //string s1 = " pooja";
        //Console.WriteLine(s1);

        //student s2 = new student(" mamata", " wankhade");
        //Console.WriteLine(s2.ToString()); //  mamata , wankhade

        //student s3 = new student(" asmita", " sarode");
        //Console.WriteLine(s3.ToString());  //  asmita , sarode


        //Console.WriteLine(s3.GetType().Name);// student
        //Console.WriteLine(s3.GetType().FullName); //  poojadighade.student

        //Type st1 = typeof(student);
        //Console.WriteLine(st1.Name); // student
        //Console.WriteLine(st1.FullName); // Poojadighade.student 

        //s3.Print(typeof(student));
        //s3.Print(s3.GetType());
        #endregion ToString() GetType()


        #region. Equal type
        //int i = 10;
        //int j = 10;
        //if (i.Equals(j))
        //{

        //    Console.WriteLine($" i & j are Equal ");

        //}
        //else
        //{
        //    Console.WriteLine($" i & j are Not Equal");

        //}
        string x = " pooja";
        string y = " dighade";

        if (x.Equals(y))
        {
            Console.WriteLine($" x & y are Equal ");

        }
        else
        {
            Console.WriteLine($" x & are Not Equal");

        }


        student S6 = new student(" Pooja", " Dighade");
        student S7 = new student(" Pooja", " Dighade");
        if (S6.Equals(S7))
        {
            Console.WriteLine($" S1 & S2 are Equal");

        }
        else
        {
            Console.WriteLine($" S1 & S2 are Not Equal");
        }
        #endregion . Equal type



        //int i  = 10;
        //Console.WriteLine(i.GetHashCode());

        //string s = " vishal";
        //Console.WriteLine(s.GetHashCode());

        //string sn1 = " lonare";
        //Console.WriteLine(sn1.GetHashCode());

        student s1 = new student(" devanand", " sable");
        Console.WriteLine(s1.GetHashCode());

        student s2 = new student(" devanand", " sable");
        Console.WriteLine(s2.GetHashCode());


        int m = 10, n = 10;
        bool B1 = m == n;
        B1 = n.Equals(m);
        B1 = n.GetHashCode() == m.GetHashCode();


        Console.ReadLine();

    }


}
namespace Object_Type_Demo
{


    class student

    {


        string firstName;
        string LastName;


        public student(string fn, string ln)
        {
            firstName = fn;
            LastName = ln;
        }

        public override string ToString()

        {
            return firstName + "" + LastName;
        }
        public void Print()
        {
            Console.WriteLine(firstName + "" + LastName);
        }
        public void print(Type type)
        {

        }
        public override bool Equals(object? obj)
        {
            student s = (student)obj;
            return firstName.Equals(s.firstName) &&
                LastName.Equals(s.LastName);
        }
        public override int GetHashCode()
        {

            return firstName.GetHashCode() *
                LastName.GetHashCode();

        }


    }

}