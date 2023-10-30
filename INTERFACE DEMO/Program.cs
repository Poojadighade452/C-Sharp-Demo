using System.Security.Cryptography;

class program
{
    static void Main()
    {

        //Icustomer i1 = new SilverCustomer();
        //i1.Print();

        //Icustomer c1 = new GoldCustomer();
        //c1.Print();
        // IFood f1 = new SilverCustomer();
        //f1.Ordered();
        //IFood f2 = new GoldCustomer();
        //Icustomer c1 = new SilverCustomer();
        //c1.SaveCustomerDetails();
        //IFood f1 = new SilverCustomer();
        //f1.saveCutomerDetails();
        //Icustomer c2 = new GoldCustomer();
        //c2.SaveCustomerDetails();
        //IFood f2 = new GoldCustomer();
        //f2.saveCutomerDetails();

        SilverCustomer sc1 = new SilverCustomer();
        ((Icustomer)sc1).SaveCustomerDetails();
        ((IFood)sc1).saveCutomerDetails();


       

        Console.ReadLine();
    }



}
interface  Icustomer
{
    void Print();
    void SaveCustomerDetails();
    public string FirstName { get; set; }
}
interface IFood
{

    void Ordered();
    void saveCutomerDetails();

    
}

class SilverCustomer : Icustomer ,IFood

{
    private string _firstName;
    public string FirstName
    {

        get { return _firstName; }
        set { _firstName = value; }
    }
    public void Print()
    {

        Console.WriteLine($" silver customer");
    }

    void IFood.Ordered()
    {
        Console.WriteLine($" Silver custome Ordered");
    }

    void Icustomer.Print()
    {
        throw new NotImplementedException();
    }

    void Icustomer.SaveCustomerDetails()
    {
        Console.WriteLine($" Icustomer saveCustomerDatails");
    }

    void IFood.saveCutomerDetails()
    {
        Console.WriteLine($"IFood  save Customer Detalis");
            
    }
}
class GoldCustomer : Icustomer,IFood
{
    string Icustomer.FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Print()
    {
        Console.WriteLine($" Gold customer");
    }

    void IFood.Ordered()
    {
        Console.WriteLine ($" Gold customer Ordered ");
    }

    void Icustomer.Print()
    {
        throw new NotImplementedException();
    }

    void Icustomer.SaveCustomerDetails()
    {
        Console.WriteLine( $" Icustomer SaveCustomerDetailes");
    }

    void IFood.saveCutomerDetails()
    {
        Console.WriteLine($" IFood SaveCustomer Details");
    }
}

