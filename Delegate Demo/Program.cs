delegate  void SampleDelegate();
delegate void sampleDelegateA(String s);
delegate void PrintDelegate();
class program
{
    static void Main()
    {
        //customer c1 = new customer();
        ////c1.PrintA();

        //SampleDelegate d1 = new SampleDelegate(c1.PrintA);
        //d1();

        ////c1.PrintB(d1);
        //SampleDelegate d1 = new SampleDelegate(Print1);
        ////SampleDelegate d2 = new SampleDelegate(Print2);
        ////SampleDelegate d3 = new SampleDelegate(Print3);
        //////SampleDelegate s1 = new SampleDelegate(Print1);
        ////SampleDelegate d = d1 + d2 + d3;
        //Console.WriteLine(d1);

        SampleDelegate d = Print1;
        d += Print2;
        d += Print3;
        d();


        //sampleDelegateA s = Prin4t;
        //s("pooja");
        Delegate[] delegates = d.GetInvocationList();
        for (int i = 0; i < delegates.Length; i++)
        {
            try
            {
                delegates[i].DynamicInvoke();
            }
           catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        Console.ReadLine();
    }
        static void Print1()
        {
            Console.WriteLine($" PrintA() Called");

        }
        static void Print2()
        {
            Console.WriteLine($" PrintB() Called");

        }
        static void Print3()
        {
            Console.WriteLine($" PrintC() Called");

        }
        static void Prin4t(string s)
        {
            Console.WriteLine($" print4 () {s}");
        }


       

}
//    
//        static void Print1()
//{
//    Console.WriteLine($" PrintA() Called");

//}
//static void Print2()
//{
//    Console.WriteLine($" PrintB() Called");

//}
//static void Print3()
//{
//    Console.WriteLine($" PrintC() Called");

//}
//static void Prin4t(string s)
//{
//    Console.WriteLine($" print4 () {s}");
//}





//}
//class customer
//{
//    public void PrintA()
//    {
//        Console.WriteLine($" printA");
//    }
//    public void PrintB(PrintA a)
//    {
//        a();
//    }


//public void PrintC()
//{

//}
//}