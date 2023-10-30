class program
{
    static void Main()
    {
        //employee e1 = new employee();
        //e1.FirstName = "pooja";
        //e1.LastName = "dighade";
        //e1.employeeId = 101;
        //e1.companyName = "dignosys technology and solution";
        //e1.Details();


        //student  s1 = new student();
        //s1.FirstName = "pranali";
        //s1.LastName = "hegde";
        //s1.RollNumber = 11;
        //s1.collegeName = "amolakchand collage of engineerings";
        //s1.details();

        //celebrity c1 = new celebrity();
        //c1.FirstName = "sharuk ";
        //c1.LastName = "khan";
        //c1.Industry = "bollywood";
        //c1.visitExpense = 100235441;
        //c1.Details();
        //c1.PrintFullName();

        //employee e1 = new person(); // compiler error
        // e1 is reference varible of type  employee pointing to employee object 
        //person p1 = new person() {FirstName = "hema" , LastName = "malini"};
        //p1.PrintFullName();

        employee e1 = new employee() { FirstName = "hemant", LastName = "borse" };
        e1.PrintFullName();



        // p2  is a refernce varible of type person pointing to employee object

        person p2 = new employee() { FirstName = "shalik ", LastName = "dighade" };
        p2.PrintFullName(); 
    
         
           


        Console.ReadLine();
    }









}










