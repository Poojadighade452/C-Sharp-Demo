class Person
{

    public string FirstName;
    public string LastName;

     public Person ( string fn, string ln)
    {
        FirstName = fn;
            LastName = ln;
    }


    public  virtual void PrintFullName()
    {

        Console.WriteLine($"full Name : {FirstName} , {LastName}");

    }

}
class Employee : Person
{
    public Employee (string fn, string ln) : base(fn, ln)
    { }
    public override void PrintFullName()
    {

        Console.WriteLine($"full Name : {FirstName} , {LastName} : employee" );

    }



}
class PermanetEmployee : Employee
{

    public PermanetEmployee(string fn, string ln) : base(fn, ln)
    {

    }
    public override void PrintFullName()
    {

        Console.WriteLine($"full Name : {FirstName} , {LastName}: permenetemployee ");

    }

}
class Celebrity : Person
{

     public Celebrity (string fn, string ln) : base(fn, ln)
    {

    }

    public override void PrintFullName()
    {
        Console.WriteLine($" full Name : {FirstName} ,{LastName} : Celebrity");

    }
}

class Student : Person
{

    public Student(string fn, string ln) : base(fn, ln)
    {

    }

    public override void PrintFullName()
    {
        Console.WriteLine($" full Name : {FirstName} ,{LastName} : Student");

    }
}

