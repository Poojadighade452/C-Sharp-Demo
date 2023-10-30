using System.Data;
using System.Runtime.InteropServices;

class program
{
  static void Main()
    {

        Calculator c1 = new Calculator();
        //c1.Add(20, 85);
        //c1.Add(210);
        //c1.Add(20, 32, 542);




        //c1.Add("shamal");
        Print(10, 50);
        short a = 10, b = 20;
        Print(a, b);
        

        Console.ReadLine();

    }



    static void Print(int a, int b)
    {
        Console.WriteLine($" print ( int a, int b)");
    }
    static void Print(short a, short b)

    {
        Console.WriteLine($" printName ( short a , short b) ");
    }

}
 class Calculator

{    
     public void Add (out int a )
    {
        a = 10;
        Console.WriteLine(a);

    }

    // public void Add(ref int a)
    //{
    //    Console.WriteLine(a);
    //}




    public void Add ( string a)
    {
        Console.WriteLine(a);
    }
     public void Add( int a)
    {
        Console.WriteLine(a);

    }
     public void Add( int a, int b)
    {
        Console.WriteLine(a + b);


    }
     public void Add( int a , int b,int c)
    {
        Console.WriteLine(a + b + c);
    }
     public void Add( float a, int b)
    {
        Console.WriteLine(a + b);

    }
    public void Add(int[] numbers)
    {
        Console.WriteLine(numbers);
    }

    public void Add( int a ,  float b)
    {
        Console.WriteLine(a + b);
    }
}