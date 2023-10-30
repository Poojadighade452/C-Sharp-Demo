using System.Linq;

class program
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 1, 3, 4, 5, 6, 7, 8, 9 };
        List<int> eventNumbers = new List<int>();
        List<int> OddNumbers = new List<int>();

        int SumEven = 0;
        int sumodd = 0;

        foreach (int item in numbers)
        {
            
            if (item % 2== 0)
            {
                eventNumbers.Add(item);
                SumEven += item;

            }
            else
            {
                OddNumbers.Add(item);
                sumodd += item;

            }
        }
        Console.WriteLine($" Addition of all even numbers is   { SumEven} ");

         foreach (int item in eventNumbers)
        {
            Console.WriteLine($" {item} is even ");
        }

         foreach (int item in OddNumbers)
        {
            Console.WriteLine($" {item} is odd");
        }
        Console.WriteLine($" numbers of even numbers is {eventNumbers.Count}");
        Console.WriteLine($" numbers of off numbers is {OddNumbers.Count}");
        Console.WriteLine($" Addition of all Odd numbers is {sumodd} ");


        var numForamat = from i in numbers
                         select 0 + i; // 1,3,4,5,6,7,8,9


        foreach(int item in numForamat)
        {
            Console.Write($" {item}");
        }


         

        Console.ReadLine();
    }
}