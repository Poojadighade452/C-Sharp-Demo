using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class program
{
    static void Main()
    {

        Calculator c1 = new Calculator();
        //c1.Add(10, 50);
        c1.Add(10, 20, 50, 89, 25, 45, 4632, 52, 124, 895, 456, 78954, 125563, 123546, 789545);
           











        Console.ReadLine();
    }



}
class Calculator
{
    [Display(Name = "First Number")]

    public int Numbers1 { get; set; }


    [ObsoleteAttribute("Add(int , int ) is outdated , use Add(params int[]")]
    public void Add([Optional](int a, int b))
    {

        Console.WriteLine($" Addition : {a + b}");
    }
    public void Add( params int[] numbers)
    {
        if (numbers != null && numbers.Length > 0)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($" Addition : {sum}");

        }
        else
        {
            Console.WriteLine(" Empty Array");
        }


    }


}