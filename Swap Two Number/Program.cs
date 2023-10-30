using System.Diagnostics.CodeAnalysis;

class program
{
    static void Main()
    {
        //Console.WriteLine(" please enter first number");
        //int a = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("please enter second number");
        //int b = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine($"first number: {a} \nsecond number {b} ");
        //int c = a;
        //a = b;
        //b = c;
        //Console.WriteLine($" first number : {a} \nsecond number {b}");

        Console.WriteLine("please enter  a number");
        int num = Convert.ToInt32(Console.ReadLine());
        IsPrime(num);



        Console.ReadLine();


    }

    static void IsPrime(int num)
    {
        bool isPrime = false;
        for (int i = 2; i < num /2; i++)
        {

            if (num % i == 0)
            {
                //Console.WriteLine($" Firstly found{num} is divisible by {i}");
                isPrime = true;
                break;


            }
        }
        if (isPrime)
        {
            Console.WriteLine($" {num} is  not prime number");
        }
        else
        {
            Console.WriteLine($" {num} is a prime number");
        }
        
        
    } 
        
      



}