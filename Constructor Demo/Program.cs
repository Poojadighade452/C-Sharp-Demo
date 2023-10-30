using System.Runtime.Intrinsics.Arm;

class program

{

    static void Main()
    {

        student s1 = new student( );
        s1.FirstName = " dighade";
        s1.LastName = "dpoade";


        //student s5 = new student();
        //s5.PrintFullName();


        student s2 = new student() { FirstName = "neha", LastName = "deshpande" };
                        
        s2.PrintFullName();

        student s3 = new student( "ruhi", "Balha");
       
        s3.PrintFullName();

        student s4 = new student("devanand", "sable");
    
        s4.PrintFullName();

        student s5 = new student(s4);
        s5.PrintFullName();
        Console.ReadLine();


    } 
   
     
    
    
     

}