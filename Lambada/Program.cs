delegate void Delegates1();


class program
{
    static void Main()
    {

        Delegates1 d1 = new Delegates1(PrintA);
            



        Console.ReadLine();
    }
    static void PrintA()
    {
        Console.WriteLine($" PrintA");
    }
}