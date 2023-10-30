class employee : person
{
    public string FirstName;
    public string LastName;
    public int employeeId;
    public string companyName;


    public  new void   PrintFullName()
    {
        Console.WriteLine($"full Name : {FirstName} {LastName} - EMPLOYEE" );

    }


    public void Details ()
    {

        Console.WriteLine($"****** Details********* \n" +
            $"first Name : {FirstName} \n" +
            $" lastName : {LastName} \n" +
            $"employeeid : {employeeId} \n" +
            $"company Name : {companyName} \n ");
             

            
    }



}
