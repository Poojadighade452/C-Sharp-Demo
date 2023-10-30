using System.Globalization;

class program
{
    static void Main()
    {
        Fact(5);
        int result = Factorial(10);
        Console.WriteLine(result);


    //    int[] numbers = new int[] { 1, 3, 56, 7, 8, 54, 3, 2, 4 };
    //    for (int i = 0; i < numbers.Length; i++)
    //    {

    //        Console.Write($" {numbers[i]}");

    //    }
    //    Console.WriteLine();

    //    //int[,] numbers1 = new int[2][] { { 1, 2 }, { 5, 3 } };
    //    //  arrray of arrays
    //    int[][] numbers2 = new int[3][];
    //    {
    //        numbers2[0] = new int[3] { 8, 2, 3 };
    //        numbers2[1] = new int[2] { 5, 2 };
    //        numbers2[2] = new int[4] { 5, 6, 4, 5 };
    //};

    //    for (int i = 0; i <numbers2.Length; i++ )
    //    { 
    //        for(int j = 0; j< numbers2[i].Length; j++)
    //        {

    //            if(i== 1 && j == 1)
    //            {
    //                Console.Write($" {numbers2[i][j]} *");

    //            }
    //            else
    //            {
    //                Console.Write($" {numbers2[i][j]}");
    //            }




    //            Console.Write($" {numbers2[i][j]} ");

    //        }
    //        Console.WriteLine();


            static void Fact(int num )
            {
                int result = 1;
                for (int i = num; i> 0; i--)
                {
                    result *= i;
                }
                Console.WriteLine($" Factorial of numbers {num} is {result} ");
            }

        static int Factorial(int num)
        {
            if (num == 1)
                return 1;
            return num * Factorial(num - 1);

        }

        
        Console.ReadLine();
    }

    
}