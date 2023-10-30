using System.Security.Cryptography;

class program
{

    static void Main()
    {

        Customer v1 = new SilverCustomer();
        v1.PrintTicket();

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
abstract  class Customer
{


    public abstract void PrintTicket();
   
}
class SilverCustomer : Customer
{
    public override void PrintTicket()
    {
        Console.WriteLine($" Silver Customer Ticket");
    }


}
class GoldCustomer : Customer
{
    public override void PrintTicket()
    {
        Console.WriteLine($" Gold Customer Ticket");

    }
}
class ViPCustomer : SilverCustomer,GoldCustomer
{ 


}
