using System.ComponentModel;

class program
{
    static void Main()
    {
        //       string name = "Main";

        //       Console.WriteLine(name); // main
        //       PrintA(ref name);
        //       Console.WriteLine(name); // printA
        //       Console.ReadLine();
        //int a = 10, b = 5, add, sub, mul, div;
        //Operation(a, b, out add, out sub, out mul, out div);

        //Console.WriteLine($" addition : {add}");
        //Console.WriteLine($"substraction : {sub}");
        //Console.WriteLine($"multiplication : {mul}");
        //Console.WriteLine($"division: {div}");
        //Console.ReadLine();
        int[] n1 = new int[] { 10, 20, 30 };
        Printsum(n1);// 60

        Printsum(new int[] { 10, 60, 90 });

        int[] n2 = null;
        Printsum(n2);// empty array
        Printsum(20, 50, 85, 65, 523);
        Printsum();
        Console.ReadLine();
    }

    //   static void PrintA( ref string name )
    //   {
    //       name = "PrintA";
    //   }

    static void Operation(int a, int b,
        out int add, out int sub, out int mul, out int div)
    {
        add = a + b;
        sub = a - b;
        mul = a * b;
        div = a / b;


    }

    static void Printsum( params int[] numbers)
    {
        if (numbers != null && numbers.Length > 0)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"sum : {sum}");
        }


        else
        {
            Console.WriteLine("empty array");
        }



    }

} 