using l1 = Library1;
using Library2;


class program
{

    static void Main()
    {
        //Library1.calculator c1 = new Library1.calculator();
        l1.calculator c1 = new l1.calculator();
        int result = c1.Add(20, 54);
        Console.WriteLine(result);


        //Library2.calculator c2 = new Library2.calculator();
        calculator c2 = new calculator();
        result = c2.Sub(65, 21);
        Console.WriteLine(result);


        Utility u1 = new Utility();
        result = u1.Getotp();
        Console.WriteLine(result);
          

        Console.ReadLine();
    }
}




