using System.Collections;
//using System.Collections.Generic;

class Program
{


    static void Main()
    {



        //Console.WriteLine(" please enter a number");
        //int input = int.Parse(Console.ReadLine());
        //if (input % 2 == 0)
        //{
        //    Console.WriteLine($" Number is : {input} Even");
        //}
        //else
        //{
        //    Console.WriteLine(" Number is Odd");
        //}


        //string name = "vishal";

        //string result = name.ReverseInput();
        //Console.WriteLine($"{name} : {result}");


        //Console.WriteLine("Please enter a name");
        //string input = Console.ReadLine();


        //result = input.ReverseInput();
        //Console.WriteLine($"{name} : {result}");



        //string[] names = new string[] { "i", "Love", "India" };

        //string result = string.Empty;

        //for (int i = names.Length - 1; i >= 0;  i--)
        //{
        //    result += names [ i ];
        //}
        //Console.Write ( result );




        /////Console.WriteLine("please enter a number");
        ////int num = int.Parse(Console.ReadLine());



        ////for(int i = 1; i<= 10; i++)
        ////{
        ////    Console.WriteLine( $" table of {num} :{num} * {i} = {num *i}" );
        ////}





        //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //int EvenNumber = 0; int Oddnumber = 0;
        //int sumEvennumber = 0; int SumOddnumber = 0;

        //for (int i = 0; i < numbers.Length; i++)
        //{


        //    EvenNumber = numbers[i];

        //    if (numbers[i] % 2 == 0)
        //    {

        //        Console.WriteLine($"  {EvenNumber} : EVEN ");
        //        EvenNumber++;
        //        sumEvennumber += numbers[i];


        //    }
        //}


        //for (int j = 0; j < numbers.Length; j++)
        //{
        //    Oddnumber = numbers[j];

        //    if (numbers[j] % 2 != 0)
        //    {

        //        Console.WriteLine($" {Oddnumber} : ODD ");
        //        Oddnumber++;
        //        SumOddnumber += numbers[j];
        //    }



        //}



        //Console.WriteLine("number of even " + EvenNumber);
        //Console.WriteLine($" number of odd :" + Oddnumber);
        //Console.WriteLine($" sum of even " + sumEvennumber);
        //Console.WriteLine($" sum of Odd " + SumOddnumber);





        int[] num = { 5, 15, 65, 84, 56, 78, 95, 125, 524, 785 };

        int Highestnumber = 0;
        int LowestNumber = 0;
        for (int i = 0; i < num.Length; i++)
        {
            Highestnumber = num[i];

            for (int j = 0; j < num.Length; j++)
            {
                if (num[i] == num[j])

                    continue;
                if (num[j] > Highestnumber)
                {
                    Highestnumber = num[j];
                }

            }


        }
        Console.WriteLine($" Highest number is : {Highestnumber}");


        for (int x = num.Length - 1; x >= 0; x--)
        {
            LowestNumber = num[x];

            for (int y = num.Length - 1; y >= 0; y--)
            {
                if (num[x] == num[y])

                    continue;
                if (num[y] < LowestNumber)
                {
                    LowestNumber = num[y];
                }

            }


        }

        Console.WriteLine($" Lowest number is :{LowestNumber} ");



        Console.ReadLine();
    }

}
//public static class Student
//{


//    public static string ReverseInput(this string s)
//    {
//        string result = string.Empty;
//        for (int i = s.Length - 1; i >= 0; i--)
//        {
//            result += s[i];
//        }

//        return result;
//    }
List<int> numbers = new List<int>() { 1, 3, 4, 5, 6, 7, 8, 9 };
List<int> eventNumbers = new List<int>();
List<int> OddNumbers = new List<int>();

int SumEven = 0;
int sumodd = 0;

foreach (int item in numbers)
{

    if (item % 2 == 0)
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
Console.WriteLine($" Addition of all even numbers is   {SumEven} ");

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





// }

