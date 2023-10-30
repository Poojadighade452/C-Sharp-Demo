
class celebrity : person
{

    public string Industry;
    public double visitExpense;

    public void Details()
    {
        Console.WriteLine($" ********** Details *********** \n " +
             $" First Name : {FirstName} \n " +
             $" Last Name : {LastName} \n " +
             $" industry : {Industry} \n" +
             $" visit expance : {visitExpense}");
    }

}