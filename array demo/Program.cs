

class progrma
{
    static void Main()
    {
        //string n1 = "pooja";
        //string n2 = "dikshya";
        //string n3 = "swati";
        //string n4 = " sneha";

        //string[] names = new string[] { "pooja", "dikshya", "swati", "sneha" };
        //Console.WriteLine(names[0]);//pooja
        //Console.WriteLine(names[2]);//swati
        //Console.WriteLine(names[4]);

        //for (int i = 0; i < names.Length; i++)
        //{

        //    Console.WriteLine($"{names[i]} ");
        //}

        int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int even = 0, odd = 0;
        for (int i = 0; i < number.Length; i++)
        {
            even = number[i];
            if (number[i] % 2 == 0)
            {
                Console.WriteLine($" {number[i]} : EVEN ");
                even++;
            }

            else
            {

                Console.WriteLine($" {number[i]}: ODD");
                odd++;
            }
        }
        Console.WriteLine("odd number " + odd);
        Console.WriteLine("event " + even);

        //int[] num = { 10, 50, 84, 79, 99, 412 };
        //Console.WriteLine($" Highest numberr is : {num[5]} ");
        //int highestnumber = 0;
        //for (int i = 0; i< num.Length; i++)
        //{
        //    highestnumber = num[i];
        // for (int j= 0; j< num.Length; j++)
        //    {
        //        if (num[i] == num[j])
        //            continue;
        //        if (num[j] > highestnumber)
        //        {
        //            highestnumber = num[j];
        //        }
        //    }
        //    Console.WriteLine($"highest number : {highestnumber}");

        //string[,] names = {
        //    {"mahesh","M"},
        //    {" PRAKASH" , "P"},
        //    {"VIKAS", "V" }
        //};
        
        //for ( int i =0; i<3; i++)
        //{
        //    for ( int j= 0; j<2; j++)
        //    {
        //        Console.WriteLine($"{names[i,j]} ");
        //    }

        //}
        Console.WriteLine();// new lines


        Console.ReadLine();



    }


      



     

}

















