using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

class program
{
    private static string Choice;

    static void Main()
    {
        //do
        //{

        //    try
        //    {
        //        Console.WriteLine($"Please Enter a number");
        //        int i = Convert.ToInt32(Console.ReadLine());

        //        Console.WriteLine($" Your Entered Number  is : {i}");



        //    }
        //    catch (Exception ex)
        //    {


        //        Console.WriteLine(ex.Message);

        //    }
        //    Console.WriteLine($" do you want to continue");

        //    Choice = Console.ReadLine().ToUpper();


        //} while (Choice == "Y" || Choice == "Yes");


        //Console.WriteLine($" Thank you Visit Again");


        string choice = string.Empty;
        do
        {
            try
            {
                Console.WriteLine($" Please enter a Numerator");
                int i = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine($" Please enter a dinominator");
                int j = Convert.ToInt32(Console.ReadLine());

                int div = i / j;

                Console.WriteLine($" Divison = {i} / {j} = {div}");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($" Do want to Continue ?");
            choice = Console.ReadLine().ToUpper();


        } while (choice == "Y" || choice == " Yes");


        Console.WriteLine($" Thank You Visit Again");

          Console.ReadLine(); 
    }
}