class program
{


    static void Main()
    {
        // person p1 = new person( "padma",  "hedge" );

        //p1.PrintFullName(); // person class method

        // p1 = new employee("rahul ", "dighade");
        //     p1.PrintFullName(); // employee class method  

        // p1 = new permanetEmployee("atul ", "rathod");
        // p1.PrintFullName(); // permantEmployee class method

        Person[]Persons = new Person[5];

        Persons[0] = new Person("Anil", "Rathod");
        Persons[1] = new Employee("Deshmukh", "Hema");
        Persons[2] = new PermanetEmployee("Madhuri", "Dikxit");
        Persons[3] = new Celebrity("Ritik", "Deshmukh");
        Persons[4] = new Student(" Hema", "Deshpande");

        for (int i =0; i < Persons.Length; i++)
        {
            Persons[i].PrintFullName();
        }


        Console.ReadLine();
    }

    
}