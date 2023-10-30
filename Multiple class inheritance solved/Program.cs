class program
{

    static void Main()
    {

        Customer v1 = new SilverCustomer();
        //v1.PrintTicket();
        VIPCustomer vip = new VIPCustomer();
        ((ISilverCustomer)vip).PrintTicket();
        ((IGoldcustomer)vip).PrintTicket();


        vip.printG();
        vip.PrintS();

        Console.ReadLine();
    }



}
//class CinemaCustomer
//{

//    public void ShowTimings()
//    {
//        Console.WriteLine($" All show for todays" );

//    }
//}
//class Food
//{


//    public void FoodOrder()
//    {
//        Console.WriteLine($" Ordered Food");
//    }
//}
//class SilverCustomer : CinemaCustomer , Food

//{

//}
abstract class Customer
{


    public abstract void PrintTicket();

}
class SilverCustomer : Customer,ISilverCustomer
{
    public override void PrintTicket()
    {
        Console.WriteLine($" Silver Customer Ticket");
    }

    void ISilverCustomer.PrintS()
    {
        Console.WriteLine( $" silver");
    }

    void ISilverCustomer.PrintTicket()
    {
        throw new NotImplementedException();
    }
}
interface ISilverCustomer
{
    void PrintTicket();
    void PrintS();
}
class GoldCustomer : Customer ,IGoldcustomer
{
    public override void PrintTicket()
    {
        Console.WriteLine($" Gold Customer Ticket");

    }

    void IGoldcustomer.printG()
    {
       Console.WriteLine( $" Gold");
    }
}


interface  IGoldcustomer
{
    void PrintTicket();
    void printG();
}
//class ViPCustomer : SilverCustomer, GoldCustomer
class VIPCustomer : ISilverCustomer, IGoldcustomer
{


    SilverCustomer sc = new SilverCustomer();
    GoldCustomer gc = new GoldCustomer();

    public void printG()
    {
        ((IGoldcustomer)gc).printG();
    }

    public void PrintS()
    {
        ((ISilverCustomer)sc).PrintS();
    }

    void ISilverCustomer.PrintTicket()
    {
        sc.PrintTicket();
    }

    void IGoldcustomer.PrintTicket()
    {
        gc.PrintTicket();
    }
}
