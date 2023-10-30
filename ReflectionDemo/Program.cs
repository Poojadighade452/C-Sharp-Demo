using System.Reflection;



class program
{
    static void Main()
    {
        #region student class  use at runtime
        //Student s = new Student();
        //s.PrintA();



        //Assembly assembly = Assembly.GetExecutingAssembly();
        //Type studentType = assembly.GetType("Student");

        //MethodInfo printA = studentType.GetMethod("PrintA");

        //object s = Activator.CreateInstance(studentType);

        //printA.Invoke(s, null);


        //MethodInfo printB = studentType.GetMethod("PrintB");
        //printB.Invoke(null, null);

        //MethodInfo printC = studentType.GetMethod("PrintC");

        //printC.Invoke(s, new object[] {" Pooja"});

        //MethodInfo printD = studentType.GetMethod("PrintD");
        //printD.Invoke(s, null);

        #endregion student class use at runtime

        Assembly assembly = Assembly.GetExecutingAssembly();

        Type customerType = assembly.GetType("Customer");

        MethodInfo[] method = customerType.GetMethods();
        foreach(MethodInfo method1 in method)
        {
            Console.WriteLine(method1.Name);

        }

        PropertyInfo[] properties = customerType.GetProperties();
        foreach (PropertyInfo property in properties )
        {
            Console.WriteLine(property.Name);
        }
            
        Console.ReadLine();
    }
    




}

public class Student
{
    public void PrintA()
    {
        Console.WriteLine($" PrintA()");
    }
    public static void PrintB()
    {
        Console.WriteLine("PrintB");
    }
    public void PrintC(string name)
    {
        Console.WriteLine($" Printc : {name}");
    }
    public void PrintD()
    {
        Console.WriteLine($" PrintD()");
    }

}
class Customer
{
    public string Name { get; set; }
    //public  Orders { get; set; }
    //public Customer()
    //{

    //    Name = "vishal";
    //    Orders = GetOrders();
    //    Name = "pooja";
    //    Orders = new Lazy<List<Order>>(del);
    //}

    //public List<Order> GetOrders()
    //{

    //    return new List<Order>()
    //    {
    //        new Order(){ OrderId = 1,Orderdescription ="Order1"},
    //        new Order(){ OrderId = 2,Orderdescription ="Order2"},
    //        new Order(){ OrderId = 3,Orderdescription ="Order3"},
    //        new Order(){ OrderId = 4,Orderdescription ="Order4"}



        //};




    //}

}