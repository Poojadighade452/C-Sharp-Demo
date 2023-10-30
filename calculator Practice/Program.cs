
using System.Collections;

class program
{
    static void Main()
    {


        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 9, 8 };


        int even = 0, odd = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 ==0)
            {
                even++;
            }
            else
            {
                odd++;
            }
        }


        Console.WriteLine(" total number of even" + even);
        Console.WriteLine(" total number of even" + odd);












        Console.ReadLine();
    }
}