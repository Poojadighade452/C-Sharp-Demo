class program
{

    static void  Main()

    {
        circle c1 = new circle();
    c1.radius = 25;
        c1.Area();

        circle c2 = new circle();
    c2.radius = 15;
        c2.Area();


student.courseName = "dot net";
student s1 = new student();
{
   s1.FirstName = "mahesh";
    s1.lastname = "namdev";


};
s1.Details();
student s2 = new student();
{
    s2.FirstName = "swati";
    s2.lastname = "devtale";
}
s2.Details();
Console.ReadLine();

    }

}
class student
{ // fields

    public string FirstName; // non static field / instance fields
    public String lastname;
    public static string courseName; // static fields


    // method
    public void Details()
    {
        Console.WriteLine($" ********** Details **********\n" +
            $"FirstName = {FirstName} \n" +
             $"LastName = {lastname}\n" +
             $"CourseName = {courseName}");

    }
}


class circle
{
    public int radius;
    public static float pi = 3.14f;
    public int area;

    public void Area()
    {

         Console.WriteLine( $" Area of circle having  radius = {radius}  : {pi  * radius * radius} ");

    }





}


// class program1 
// {

// static void Main()
//    {
//        employee e1 = new employee();
//        e1.name = "pooja";
//        e1.id = 1;
//        e1.details(); 
//        Console.ReadLine();
//    }



//}
//class employee
//{

//    public int id;
//    public string name;
//    public static int batch = 2;


//    public void details()
//    {
//        Console.WriteLine($" employee details : id ={id} \n  name ={name} \n,  batch ={batch}");
//    }


//}
