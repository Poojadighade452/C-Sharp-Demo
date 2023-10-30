class program
{
 static void Main()
    {
        int i = 10;
        string name = "vishal";

        i++;
        Console.WriteLine(i);//11

        object o = i; // int -> object 
        // value type -> reference type =boxing

        Console.WriteLine(o);
        int j = (int)o; // object-> int
        // reference type => value type = unboxing
        Console.WriteLine( j);

        Console.ReadLine();











    }



















}