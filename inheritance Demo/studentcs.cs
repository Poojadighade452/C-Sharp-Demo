using System.ComponentModel;

class student : person
{
     //student class is inheriting person class
     // student class= child class / derived class
     //person class = Parent class / base class




    public string FirstName;
    public string LastName;
    public int RollNumber;
    public string collegeName;

    public void PrintFull()
    {
        Console.WriteLine($"full Name : {FirstName}, {LastName}");

    }


        public void  details()
    {
        Console.WriteLine($"******* Details ******\n +" +
            $" First Name : {FirstName} \n " +
            $" last name : {LastName} \n" +
            $" roll Number : {RollNumber} \n " +
            $" college Name : {collegeName} \n");
    }




}