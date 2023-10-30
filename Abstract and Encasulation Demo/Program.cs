
using System.Runtime.Intrinsics.X86;

class program
{
    static void Main()
    {

        //student s1 = new student();
        //s1.FirstName = " Mahesh";
        //s1.LastName = " Bajwa";
        //s1.Print();
        student s1 = new student(" Hemata", " Hantwar"); 


        s1.Print();
        student s2 = new student(" pooja", "");
        string fn1 = s2.GeFirstName();
        Console.WriteLine(fn1);
        s2.Print();
        student s3 = new student(" ", "");
        s3.Print();
        student s4 = new student(" pooja", " dighade");
        s4.Print();

        string fn = s4.GeFirstName();
        Console.WriteLine(fn);

        ////if (s2.IsValiDate ())
        ////  {
        //       s1.Print();
        //  }
        //else
        //   {
        //       Console.WriteLine(" Please check Data");
        //   }
        Console.ReadLine();
    }


   
}
class student
{
    //public string FirstName;
    //public string LastName;
    private string FirstName;
    private string LastName;

    public student ( string firstName , string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

       
    }

    private bool IsValiDate()
    {

        return !string.IsNullOrEmpty(FirstName)
            && !string.IsNullOrEmpty(LastName);

    }
    public string GeFirstName()
    {
        return FirstName;
    }

    public void Print ()
    {
        if ( IsValiDate())
        {

            Console.WriteLine($" Full Name : {FirstName}, {LastName} ");
        }
        else
        {


            Console.WriteLine( $" Please check your Date");
        }
    }


}