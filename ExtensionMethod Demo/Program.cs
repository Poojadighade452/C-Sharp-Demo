using System.Reflection.Metadata.Ecma335;

class program
{

    static void Main()
    {
        Person p = new Person();
        p.PrintA();

        //PersonHelper.PrintB;
        string name = " vishal";
        name.PrintB(10);

        string result = name.ReverseInput();
        Console.WriteLine($" {name} : {result}");

        Console.WriteLine($" please enter a name");
        string input = Console.ReadLine();
        result = input.ReverseInput();
        Console.WriteLine($" {input} : {result}");




        Console.ReadLine();
    }



}
 public sealed class Person
{
    public void PrintA()
    {
        Console.WriteLine(" PrintA()");
    }
public void PrintB()
    {
        Console.WriteLine("PrintB()");

    }



}
public static class PersonHelper
{
    public static void PrintB( this Person p)
    {
        Console.WriteLine("PrintB()");

          
    }
    public static void PrintB(this string p , int i)
    {
        Console.WriteLine($"PrintB() : {i}");
    }
    public static string ReverseInput(this string s)
    {
        string result = string.Empty;
            for (int i = s.Length - 1; i>=0; i--)
            {
                result += s[i];
            }
        return result;
    }  
}