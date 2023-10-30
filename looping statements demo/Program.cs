
using System.Xml.Schema;

class program
{
    static void Main()


    #region commented code
    //int i = 1;

    //do
    //{
    //    Console.WriteLine(i);
    //    i++;
    //} while (i <= 5);

    // while ( i <= 9)
    //{
    //    Console.WriteLine(i);
    //    i++;
    //}


    //for (int i = 1; i <= 5; i++)
    //{

    //    if (i == 3)
    //    {
    //        break;
    //    }

    //    Console.WriteLine(i);

    //}

    //for (int i = 1; i <= 10; i++)
    //{
    //    if (i == 1)
    //    {

    //    }
    //    if (i == 2 || i == 3)
    //    {

    //        continue;
    //    }
    //    Console.WriteLine(i);



    //}


    //for (int i = 1; i <= 5; i++)
    //{
    //    Console.WriteLine(i);


    //    if ( i == 2)
    //    {
    //        //break;
    //        i = 5;

    //    }

    //}   


    //for (int i = 1; i <= 5; i++ ) 
    //{ 
    // for ( int j = 1; j <= 5; j++ )
    //    {
    //        Console.WriteLine("*\n");
    //    }

    //    Console.WriteLine();// new line

    //}

    //Console.WriteLine();// new line
    //Console.WriteLine(" MAIN ENDS HERE");

    #endregion commented code


    {

        int totalbill = 0;
        string choice = "";
        int totalsamosa = 0, totalcoffee = 0, totaltea = 0, totalwadapav = 0;
        Console.WriteLine("------- today's menu-------");

        do
        {




            Console.WriteLine(" wada pav\n samosa\n tea\n coffee");
            Console.WriteLine(" what would you like to take");
            string order = Console.ReadLine();

            switch (order.ToUpper())
            {


                case "WADA PAV":
                    Console.WriteLine(" how much WADA PAV?");
                    int tw = int.Parse(Console.ReadLine());

                    totalwadapav += tw;
                    //totalbill += 20;
                    break;

                case "SAMOSA":
                    Console.WriteLine("how much SOMOSA ?");
                    int ts = int.Parse(Console.ReadLine());
                    totalsamosa += ts;
                    //totalbill += 20;
                    break;
                case "TEA":
                    Console.WriteLine("how many TEA?  ");
                    int tt = int.Parse(Console.ReadLine());

                    totaltea += tt;
                    //totalbill += 10;
                    break;
                case "COFFEE":
                    Console.WriteLine(" how many COFFEE ? ");
                    int tc = int.Parse(Console.ReadLine());
                    totalcoffee += tc;
                    //totalbill += 20;
                    break;
                default:
                    Console.WriteLine($" {order} not available");
                    break;
                    Console.WriteLine("do you want to continue ");


            }
            Console.WriteLine(" do you want to continue");
            choice = Console.ReadLine();


        } while (choice == "y" || choice == "yes");
        if (totalwadapav > 0 || totaltea > 0 || totalcoffee > 0 || totalsamosa > 0)
        {
            Console.WriteLine("*************BILL RECIEPT****************");
        }
        if (totalwadapav > 0)
        {
            Console.WriteLine($" wadapav {totalwadapav}*20  :{totalwadapav * 20}");
            totalbill += totalwadapav * 20;
        }
        if (totalsamosa >0)
        {
            Console.WriteLine($" samosa {totalsamosa}*20 : {totalsamosa * 20} ");
            totalsamosa += totalsamosa * 20;
        }
        if (totaltea > 0)
        {
            Console.WriteLine($" tea {totaltea} * 10 : {totaltea * 10}");
            totaltea += totaltea * 10;
        }
        if (totalcoffee  > 0)
        {
            Console.WriteLine($" coffee{totalcoffee} * 20:{totalcoffee * 20}");
            totalcoffee += totalcoffee * 20;
        }

        if (totalbill > 0)
        {
            Console.WriteLine("_________________________________");


            Console.WriteLine($" total bill amount : {totalbill}");
        }
        else
        {
            Console.WriteLine("NO BILL");
        }
        Console.WriteLine(); //new line

        Console.WriteLine(" thank you visit again");

        Console.ReadLine();
        
        
        
        
      
        






        
    }




        
        




             
        


















    }
















