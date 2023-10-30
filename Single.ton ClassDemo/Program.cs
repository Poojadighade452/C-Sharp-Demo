using System.Data;
using System.Globalization;
using System.Net.Http.Headers;

class program
{
    static void Main()
    {

        Customer c1 = Customer.Instance;
        Customer c2 = Customer.Instance;
        Customer c4 = Customer.Instance;
        Customer c3 = Customer.Instance;
        Customer c5 = Customer.Instance;
        Customer c6 = Customer.Instance;


        if (c5.Equals(c6))
        {
            Console.WriteLine("Same");
        }
        else
        {
            Console.WriteLine($" Not Same");
        }
        








        Console.ReadLine();
    }


}
public class Customer
{
    static Customer  _obj = null;
    static int  _counter = 2;
    

    private Customer()
    {
       
    }
    public static Customer Instance
    {
        get
        {

            if (_obj == null || _counter <= 5)
            {
                _obj = new Customer();
                _counter++;

            }
            else
            {
                throw new Exception("only  five objects are possible");
            }
            return _obj;
        }
        
        
               

    }
}