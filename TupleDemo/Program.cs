class Program
{

    static void Main()
    {
        Tuple<int, int, int> Numbers1 = new Tuple<int, int, int>(10, 20, 30);
        Console.WriteLine(Numbers1.Item2);

        Tuple<int, int, int, int, int, int,Tuple<int, int, int>> numbers2 = new Tuple<int, int, int, int, int, int ,Tuple<int, int, int >>(1,2,3,4,5,6,Numbers1);

        Console.WriteLine(numbers2.Item7);
        Console.WriteLine(numbers2.Item2);



        Console.ReadLine();

    }


}
