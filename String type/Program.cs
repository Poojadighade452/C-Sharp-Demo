
using System.Threading.Channels;

class program
{

    static void Main()
    {
        string firstName = "pooja";
        Console.WriteLine(firstName);

        Console.WriteLine(firstName.ToUpper());
        Console.WriteLine(firstName.ToLower());

        Console.WriteLine(firstName.Length);
        firstName = "  pooja  ";
        Console.WriteLine(firstName.Trim());

        firstName = "\"pooja\"";
        Console.WriteLine(firstName);

        firstName = "pooja";
        string lastName = "dighade";

        string fullName = firstName + " " + lastName;
        Console.WriteLine(fullName);


        fullName = string.Concat(firstName, " ", lastName);
        Console.WriteLine(fullName);

        fullName = string.Join(',', firstName, lastName);
        Console.WriteLine(fullName);

        fullName = string.Format($"full Name = {firstName} {lastName}");
        Console.WriteLine(fullName);
        Console.WriteLine($"fullname = {lastName}, {firstName}");



        int a = 10, b = 10;
        Console.WriteLine(a + b);
        string n1 = a.ToString();
        string n2 = b.ToString();
        Console.WriteLine(n1 + n2);






        Console.ReadLine();


    }


}

