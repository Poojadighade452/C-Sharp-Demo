class program
{

    static void Main()
    {


        Student s1 = new Student();
        s1.FirstName = " Anil";
        s1.LastName = " Rathod";
        //s1.Gender = " Male";
        s1.Gender = Gender.Male;


        Student s2 = new Student();
        s2.FirstName = " vishali";
        s2.LastName = " Pawar";
        s2.Gender = Gender.Female;
       

        Console.WriteLine($" FirstName : {s1.FirstName} , LastName : {s1.LastName} , Gender : {s1.Gender} ");

        Console.WriteLine($" FirstName : {s2.FirstName} , LastName : {s2.LastName} , Gender : {s2.Gender}");




        Type t = Enum.GetUnderlyingType(typeof(Subject));
        Console.WriteLine($" Underlying type : {t.Name}");

        string[] names = Enum.GetNames(typeof(Subject));
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($" {names[i]}");


        }
        Console.WriteLine();

        int[] values = (int[])Enum.GetValues(typeof(Subject));
        for (int i = 0; i < values.Length; i++)

        { 
            Console.Write($" {values[i]}");
        }

        static string GetGender(int gender)
        {
            switch (gender)
            {


                case 1:
                    return " Male";
                case 2:
                    return " Female";
                case 3:
                    return " Other";

                default:
                    return " Unknown";




            }





        }

            Console.ReadLine();
    }

   
}
class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //public string Gender { get; set; }
    public Gender Gender { get; set; }



}


    enum Gender
    {


        Male, Female, other
    }
    enum Subject 
    {

        Marathi, Hindi, History, English, Chemistry, Physics, Mathematics = 10

    }