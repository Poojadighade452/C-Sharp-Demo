using System.Security.Cryptography.X509Certificates;

public delegate bool DiscountCriteria(Student student);


public class Institute
{
    public string Name { get; set; }
    public const int Fees = 50000;
    Student[] Students;
    //public Institute(string name)
    //{
    //    this.Name = name;
    //}
    public Institute (string name, Student[]students)
    {
        this.Name = name;
        this.Students = students;
    }
    public void InstituteDetails()
    {
        Console.WriteLine($" Institute name : {Name}");
    }
    public void AllStudents()
    {
        if(Students != null && Students.Length > 0)
        {
            Console.WriteLine($" Total Students : {Students.Length}");
            for(int i = 0; i< Students.Length; i++)
            {
                Console.WriteLine($" RollNumber : {Students[i].RollNumber} " +
                    $"name : {Students[i].Name} city : {Students[i].City}");

            }
            
        }
        else
        {
            Console.WriteLine($" no student In {Name} Institute for Discount");
        }
    }
    public void cdacDiscountStudents( DiscountCriteria del)
    {
        if (Students != null && Students.Length > 0)
        {
            Console.WriteLine($" All Discounted Students List" );
            for (int i = 0; i < Students.Length; i++)
            {
                //if (Students[i].City == "Mumbai")
                if (del(Students[i])) 
                {


                    Console.WriteLine($" RollNumber : {Students[i].RollNumber} " +
                        $"name : {Students[i].Name} city : {Students[i].City}");
                }
            }

        }
        else
        {
            Console.WriteLine($" no student In {Name} Institute for Discount");
        }
    }

}