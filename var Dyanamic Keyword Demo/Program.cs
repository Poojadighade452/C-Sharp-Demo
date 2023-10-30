using Microsoft.VisualBasic;

class program
{
    

  static void Main()
    {

        //int v1 = 10;
        //char v2 = " $ "// error only int value are accepts
        //double v3 = 15.25;
        //student v4 = new student();

        //object v1 = 10;
        //object v2 = " $";
        //object v3 = 1253.215;
        //object v4 = new student();

        //var v1 = new { firstName = " anil ", LastName = " Rathod" };
        //Console.WriteLine(v1.firstName);
        //Console.WriteLine(v1.LastName);


        var v1 = 10; // after this line v1 will be  of type int
         var v2 = " $"; // after this line v2 will be type char
        var v3 = 1245.21;  // after this line v3 will ne type double
        
        var v4 = new student(); // afterr this line v4 will be type student
        v4.Print();
        var i = 10;
        var j = null;



        Console.ReadLine();

    }





}
class student 
{ 
 public void Print()
    {
        Console.WriteLine(" student class Print Method");

    }


}