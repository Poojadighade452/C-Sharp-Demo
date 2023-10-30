//delegate void Delegates1();
//delegate void Delegates2(string s);
delegate string Deegates3(string fn, string ln);

class program
{
    static void Main()
    {
        //Delegates1 d1 = new Delegates1(PrintA);

        //Delegates1 d1 = PrintA;

        //d1();

        //Delegates1 d1 = delegate ()
        //{
        //    Console.WriteLine(" PrintA");
        //};

        //d1();
        //Delegates1 d1 = () =>
        //{
        //    Console.WriteLine(" PrintA");

        //};
        //d1();

        //Delegates1 d1 = () => Console.WriteLine("PrintA");
        //d1();

        //Delegates2 d2 = delegate (string s)
        //{
        //    Console.WriteLine($" Hello , {s}");
        //};
        //d2("Pooja");

        //Delegates3 d3 = delegate (string fn, string ln)
        //{
        //    Console.WriteLine($" FirstName : {fn} , LastName : {ln}");

        //};
        //d3(" Pooja", " Dighade");


       Deegates3  d3 = (fn, ln) => 
        {
            string result = fn + " " + ln;
            return result;
        };
        string result = d3("anil", " rathod");
        Console.WriteLine(result);
        
       

        Console.ReadLine();
    }


    static void PrintA()
    {
        Console.WriteLine("PrintA");
    }
}