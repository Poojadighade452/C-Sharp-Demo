
//class program
//{
//    static void Main()
//    {
//        Console.WriteLine("Main() starts");

//        PrintA();

//        string r1 = PrintB();
//        Console.WriteLine(r1);

//        printc("pooja");

//        int r2 = PrintD("poojadighade");

//        Console.WriteLine(r2);

//        Console.WriteLine("Main () end");

//        Console.ReadLine();

//        // method does not have return type and parameters


//        static void PrintA()
//        {
//            Console.WriteLine(" PrintA() Method");

//        }
//        // method has return type and no parameters
//        static string PrintB()
//        {
//            Console.WriteLine("PrintB() Method");
//            return " hello from PrintB()";

//        }
//        // method has no return type and has parameters

//        static void printc(string name)
//        {
//            Console.WriteLine($" hello {name}");

//        }
//        // method has return type and has parameters

//        static int PrintD(string name)
//        {
//            return name.Length;

//        }




//    }
 // main() method  = calling method 
 class program
{
 static void Main()
    {
        string r1 = PrintA("vishal");

        Console.WriteLine(r1);
        Console.ReadLine();
    }
    // printA method = called method
    static string PrintA(string name)
    {
        return "good morning " + name;
    }
}