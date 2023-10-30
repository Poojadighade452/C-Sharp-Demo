 class program
{
 static void Main()
    {
        string email = null;
        //int  ? age = null;
        Nullable<int> age = null;

        bool   ? b = null;
        // there is not big differnecre between int and jint?
        //int? can store all value like in along with null
        int? x = null;
        //int y = (int)x; // int ? => int


        //int y;
        //if ( x != null)
        //{
        //    y = (int)x;

        //}
        //else
        //{
        //    y = 0;
        //}

        int y = x ?? 0;
                Console.WriteLine(y);// 100
        string name = "pooja";

        name = null;
        Console.WriteLine(name?.ToUpper());
        string name1 = name ?? "absence of name";
        Console.WriteLine(name1);

        



        Console.ReadLine();





    }





}