
using System.CodeDom.Compiler;

class progran
{

    static void Main()

    {

        //person p1 = new person();
        //employee e1 = new employee();
        //person p2 = new employee();

        employee e1 = new employee ("pooja", 100);
        e1.print();


        Console.ReadLine();



    }



     class person /*: Mammals*/
    {

        public string Name = "person";
        public person()
        {

        }
        //public person()
        //{
        //    Console.WriteLine($" person() called ");
        //}

        public person( int num)
        {
            Console.WriteLine($"Person (string Name)  : { num} called");
        }


    }


     class employee : person
    {
        public string Name = "employee";

       //public employee()
       // {
       //     Console.WriteLine($" employee() called ");
 
       // }

        public employee(string message , int num) : base(num)
        {
            Console.WriteLine($" employee (string message  , int num)  :called ");
        }
         public void print()
        {
            //Console.WriteLine(Name);// employee 
            //Console.WriteLine(this.Name);// employee
            Console.WriteLine(base.Name); // person
        }

    }

    // class Mammals
    //{
      
    //    public Mammals()
    //    {
    //        Console.WriteLine($" Mamamls () called");
    //    }



    //}

}

