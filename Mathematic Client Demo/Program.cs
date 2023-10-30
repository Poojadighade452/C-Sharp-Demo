using System.Runtime.InteropServices;

class Program
{

  static void Main()
    {

        p p = new p();
        p.PrintP();
         

        Console.ReadLine();

    }


}














class p
{
    protected  internal void PrintP()
    {
        Console.WriteLine("p");
    }
} 
internal class Q : p
{

    void PrintQ()
    {
        base.PrintP();
    }

}
