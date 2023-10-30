using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

class program
{
    static void Main()
    {


        //Action<string> d1 = s => Console.WriteLine($" Hello, {s}");
        //d1("Pooja");

        //Action<string, string> d2 = (fn, ln) => Console.WriteLine($"FirstName : {fn}, Lastname :{ln}");
        //d2("Dighade", "Dighade");
        //Action<int, int> d3 = (i1, i2) => Console.WriteLine(i1 / i2);
        //d3(52, 2);

        Predicate<string> d4 = s => s.Equals("pooja");
        bool b1 = d4("Vishal");
        Console.WriteLine(b1);

        //d4("Vishal");

        Predicate<int> d5 = i => i.Equals(10);
        bool b2 = d5(10);
        Console.WriteLine(b2);
        //d5(10);

        //Func<string > 
        //    public delegate Tresult func  < out TResult.();
        //Func <int ,string >
        //    public delegate TResult Func < in T , Out TResult > (Targ);
        Func<string, string, string> d6 = (s1, s2) => s1 + " " + s2;
        string r1 = d6("Atul", "Deshmukh");
        Console.WriteLine(r1);

        Func<int, int, int> d7 = (t1, t2 ) => t1 + t2;
        int r2 = d7(10, 20);
        Console.WriteLine(r2);



        Console.ReadLine();
    }





}