using System.Runtime.Intrinsics.X86;

class program
{
    static void Main()
    {


        //Calculator c1 = new Calculator();
        //bool b1 = c1.AreEqual(10, 20);
        //Console.WriteLine(b1);

        //b1 = c1.AreEqual(" hema", " hema");
        //Console.WriteLine(b1);

        //b1 = c1.AreEqual(1102m ,15420m);
        //Console.WriteLine(b1);


        //b1 = c1.AreEqual(11.5f, 11.5f);
        //Console.WriteLine(b1);

        //b1 = c1.AreEqual(" string", 10);
        //Console.WriteLine(b1);

        //Calculator c1 = new Calculator();
        //bool b1 = c1.AreEqual <int >(10, 20);
        //Console.WriteLine(b1);

        //b1 = c1.AreEqual < string >(" hema", " hema");
        //Console.WriteLine(b1);

        //b1 = c1.AreEqual < decimal> (1102m, 15420m);
        //Console.WriteLine(b1);


        //b1 = c1.AreEqual < float >(11.5f, 11.5f);

        //Console.WriteLine(b1);

        //b1 = c1.AreEqual<string>(" hema", 10);
        //Console.WriteLine(b1);// error

        //c1.Add<string>("A", "B"); // AB

        //c1.Add<int>(20, 563);// 583
        //c1.Add<float>(10.5f, 52.5f);// 63.0
        //c1.Add<decimal>(102m, 125m);//227

        //Student<string, int, string > s1 = new Student<string,int, string>();

        //s1.PrintA(" Hello");

        //string result = s1.PrintC(" pooja");
        //Console.WriteLine(result);

        //Student<Calculator, string, decimal> s2 = new Student<Calculator, string, decimal >();

        //s2.PrintA(new Calculator());
        Calculator c1 = new Calculator();
        
        long r1 = c1.GetSum <int, long>(10, 10);
        Console.WriteLine(r1);
        
            




        Console.ReadLine();

    }


   
}
class Calculator
{
    //public bool AreEqual( int a, int b)
    //{
    //    return a.Equals(b);
    //}
    //public bool AreEqual( string a , string b)
    //{
    //    return a.Equals(b);

    //}
    //public bool AreEqual( float a , float b)
    //{
    //    return a.Equals(b);

    //}

    //public bool AreEqual(decimal a, decimal b)
    //{
    //    return a.Equals(b);

    //}
    //public bool AreEqual(object a, object b)
    //{
    //    return a.Equals(b);

    //}

    //public bool AreEqual< T >(T a, T b)
    //{
    //    return a.Equals(b);
    //}

    //public void Add < T >( T a, T b)
    //{
    //     dynamic n1= a;
    //    dynamic n2 = b;

    //    Console.WriteLine(n1 + n2);
    //}
    public Tout GetSum<Tin, Tout>(Tin a, Tin b)
    {
        dynamic n1 = a;
        dynamic n2 = b;
        return n1 + n2;


    }

}
class Student  < T1, T2 ,T3 >
 {
    public void PrintA(T1 a)
    {
        Console.WriteLine($" Print A");
    }
       
    public void PrintB(T2 a)
    {
        Console.WriteLine($"Print B ");

    }

    public T3 PrintC( T1 a)
    {

        dynamic result = $" Welcome  {a}";
        return result;
    }

    public Tout GetSum< Tin , Tout> (Tin a, Tin b)
    {
        dynamic n1 = a;
        dynamic n2 = b;
        return n1 + n2;


    }
}
class student < T1 ,T2 , TResult>
{

    public void PrintA(T1 a)
    {

    }
}