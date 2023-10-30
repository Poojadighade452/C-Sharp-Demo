class program
{
    static void Main()
    {

        Customer c1 = new Customer();
        Console.WriteLine(c1.Name);

        Console.WriteLine("************ All Orders **********");
        foreach( Order item in c1.Orders)
        {
            Console.WriteLine($" {item.OrderId} : {item.Orderdescription}");
        }
        Customer c2 = new Customer();
        Console.WriteLine(c2.Name);
        Console.WriteLine("************ All Orders **********");
        foreach (Order item in c2.Orders)
        {
            Console.WriteLine($" {item.OrderId} : {item.Orderdescription}");
        }


        Console.ReadLine();

    }




}
class Order
{

    public int OrderId { get; set; }
    public string Orderdescription { get; set; }

    
}
class Customer
{
    public string Name { get; set; }
    public List<Order> Orders { get; set; }
    public Customer ()
    {

        Name = "vishal";
        Orders = GetOrders();
        Name = "pooja";
        Orders = new Lazy<List<Order>> (del);
    }

    public List<Order> GetOrders()
    {

        return new List<Order>()
        {
            new Order(){ OrderId = 1,Orderdescription ="Order1"},
            new Order(){ OrderId = 2,Orderdescription ="Order2"},
            new Order(){ OrderId = 3,Orderdescription ="Order3"},
            new Order(){ OrderId = 4,Orderdescription ="Order4"}
  


        };
            
          

        
    }

}