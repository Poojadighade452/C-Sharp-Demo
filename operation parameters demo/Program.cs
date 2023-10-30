using System.ComponentModel;
using System.Runtime.InteropServices;

class program
{

    static void Main()
    {
        //PrintA(10);// 10

        //PrintA(); // 5420 // without passing argument
        PrintB(20, 60);
        PrintB();
        PrintB(b: 10);
        PrintC(50, 45);
        PrintC();
        Console.ReadLine();




    }

    static void PrintA(int num = 5420)
    {
        Console.WriteLine($" Parameters value is : {num}");
    }

    static void PrintB(int a = 50, int b = 60)
    {
        Console.WriteLine($" total sum   = {a} + {b} ");
    }
    static void PrintC([Optional] int a , [Optional] int b )
    {
        Console.WriteLine($" {a} + {b} = {b} + {a} ");


        
    }


}