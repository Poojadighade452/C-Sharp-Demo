class program
{

    static void Main()
    {

        Student s1 = new Student();
        s1.RollNumber = 1;
        s1.Name = " hema malini";
        s1.insertStudentToDB();
        Console.WriteLine($" RollNumber : {s1.RollNumber} , Name : {s1.Name}");




        Console.ReadLine();
    }
}