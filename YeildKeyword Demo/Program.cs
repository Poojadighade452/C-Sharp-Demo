

using System.CodeDom.Compiler;

class program
{
    static void Main()
    {

        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        foreach (int num in GetEven(numbers))
        {
            Console.Write($" {num}");


        }

     


        Console.ReadLine();
    }

    static IEnumerable < int > GetEven(List<int>numbers)
    {

        foreach(int num in numbers)
        {
            if(num % 2 == 0)
            {
                yield return num;
            }
        }
    }

    
}
