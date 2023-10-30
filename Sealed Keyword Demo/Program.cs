class program
{
    static void Main()
    {
        Person p = new Person();
        p.Print();


        Employee e = new Employee();

        e.Print();

        PermanetEmployee P = new PermanetEmployee();
        P.Print();

        Console.ReadLine();
    }



}
public class Person
{

     public virtual void Print()
    {
        Console.WriteLine($" Person");

    }
    public void PrintA()
    {
        Console.WriteLine($"Person printA");
    }

}
public class Employee : Person
{
    // public sealed  override void Print()
    public override void Print()
    {
        Console.WriteLine($" Employee");
    }


}
public class PermanetEmployee : Employee
{
    public override void Print()
    {
        Console.WriteLine($" PermanetEmployee");
    }
    



}