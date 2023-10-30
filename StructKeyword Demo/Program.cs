using System.Runtime.Intrinsics.Arm;

class program
{

    
    static void Main()


    {

        DateTime date = DateTime.Now;
        Console.WriteLine(date);

        date = DateTime.Today;
        Console.WriteLine(date);
        string onlyDate = date.ToLongDateString();
        Console.WriteLine(onlyDate);

        string onlyTime = date.ToLongTimeString();
        Console.WriteLine(onlyTime);

        onlyDate = date.ToString("dd/MM/yy");
        Console.WriteLine(onlyDate);
             
        //Student s1 = new Student();
        //s1.FirstName = " Pooja";
        //s1.LastName = " Dighade";
        //s1.PrintFullName();


        ////Student s2 = new Student("Pooja", "Dighade");
        ////    s2.PrintFullName();

        Console.ReadLine();
    }

    static void Print(Person person)
    {
        person.name = "poo";
       
    }
}
class Student
{

    public string FirstName { get; set; }
    public string LastName { get; set; }


    public void PrintFullName()
    {

        Console.WriteLine($" FullName : {FirstName} , {LastName}");

    }

}
struct Person
{
    public int id;
    public string name;
    public string gender;
    public  string email;
    public string adhaar;

}