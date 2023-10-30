
class program
{

    static void Main()
    {
        Console.WriteLine("main Start");

        student s1 = new student(); // object
        s1.FirstName = "pooja";
        s1.LastName = "Dighade";
        s1.PrintfullName();
        student s2 = new student() { FirstName = "pranali", LastName = "deshmukh" };
        s2.PrintfullName();
        student s3 = new student() { FirstName = "sneha", LastName = " Fugle",  };
        s3.Details();
        student s4 = new student() { FirstName = "mahesh", LastName = "rathod", mobile = 120345126, Email = "Mahesh@gmail.com" };
        s4.Details();
        


        Console.WriteLine("Main End");

        Console.ReadLine();

    }
            

}
 class student

{// class fields
    public string FirstName;
    public string LastName;
    public int mobile;
    public string Email;
    // method
    

    public void PrintfullName()
    {
        Console.WriteLine($"fullName : {FirstName} {LastName} ");
    }

  public void Details()
    {
        Console.WriteLine($"************* Details ***********\n " +
            $"FirstName :{FirstName} \n" +
            $"lastName : {LastName} \n" +
            $"mobile : {mobile} \n "+
           $"Email : {Email} ");




    }
}