class program
{
    static void Main()
    {
        Console.WriteLine($" Welcome to calculator");
        try
        {
            Division();
        }
        catch (student ex)
        {
            Console.WriteLine(ex.GetType().Name);
            Console.WriteLine($" Error handled in enter try catch block");
        }
       
      


        Console.WriteLine(" thank you Visit Again");

        Console.ReadLine();


    }
    static void Division()
    {
        
        



            try
            {


                Console.WriteLine($" Please enter a Numarator");


                int i;
                if (int.TryParse(Console.ReadLine(), out i))

                {  Console.WriteLine($" Please enter a denominator");
                    int j;
                    if (int.TryParse(Console.ReadLine(), out j))
                   {
                        if ( j != 0)
                        {
                            int div = i / j;
                            Console.WriteLine($" Division : {i} / {j} = {div}");
                        }
                        else
                        {
                            Console.WriteLine($" denominator cannot be zero");

                        }
                    }
                    
                }
                
            }
            //catch (DivideByZeroException ex)

            //{
            //    Console.WriteLine($" Denominator cannot be zero");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($" Please enter a valid number");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($" server Error");
            //}

            catch(Exception ex)
            {
            //throw; 
            throw new DirectoryNotFoundException();
            
                //Console.WriteLine(ex.GetType().Name);
                //Console.WriteLine(ex.Message);
                //Console.WriteLine($" server error");
                File.AppendAllText(" Date\textfile1.txt", ex.Message);
                Console.WriteLine($" Please check error log in log file");
            }
        finally
        {
            Console.WriteLine($" Division Operation completed");

        }

            
    } 
} 
class student : Exception
{


}