using System.Runtime.Intrinsics.Arm;

class program
{

    static void Main()
    {
        //person p1 = new Employee();
        //p1.PrintSpeciality();
        //person p2 = new Student();
        //p2.PrintSpeciality();


        Customer c1 = new SilverMember();
        c1.ShowTimings();
        int result = c1.GetTicketAmmount();
        Console.WriteLine($" Silver ticket Ammount : {result}");
        c1.Printticket();

        Customer c2 = new GoldMember();
        c2.ShowTimings();
        result = c2.GetTicketAmmount();
        Console.WriteLine($" gold ticket Ammount : {result}");
        c2.Printticket();

        Console.ReadLine();
    }


}
public abstract class person
{

    public abstract void PrintSpeciality();


}
public class Employee : person
{
    public override void PrintSpeciality()
    {
        Console.WriteLine("Employee");
    }


}
public class Student : person
{
    public override void PrintSpeciality()
    {
        Console.WriteLine ($"Student");
    }



}
public  abstract class Customer
{
    public Customer ()
    {
        Console.WriteLine($"************ Welcome to  MaxPlayer  **********************");
    }




     public void ShowTimings()
    {
        Console.WriteLine($" All shows for todays");
    }
    public abstract int GetTicketAmmount();

    public abstract void Printticket();


}
public class SilverMember : Customer
{
    public override int GetTicketAmmount()
    {
        return 150;
    }
    public override void Printticket()
    {
        Console.WriteLine($" Silver Customer Ticket Printed");
    }
}
public class GoldMember : Customer
{
    public override int GetTicketAmmount()
    {
        return 250;
    }
    public override void Printticket()
    {

        Console.WriteLine("Gold customer ticket Printed");
    }
}