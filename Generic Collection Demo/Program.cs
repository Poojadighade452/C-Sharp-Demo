using System.Collections.Generic;
//using System.Runtime.Intrinsics.X86;

class program
{
    static void Main()
    {
        #region List

        List<int> numbers = new List<int>();
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        //Console.WriteLine($" Number of Items : {numbers.Count} ");
        //foreach (int item in  numbers)
        //{
        //    Console.Write($"{item} ");
        //}
        //Console.WriteLine(); // new line
        //IEnumerable<int> temp = new List<int>() { 30, 40, 50,60 };
        //numbers.AddRange(temp);

        //foreach(int item in numbers)
        //{
        //    Console.Write($"{item} ");

        //}

        //Console.WriteLine(); // new line

        //numbers.Insert(7, 70);
        //foreach (int item in numbers)
        //{
        //    Console.Write($"{item} ");
        //}
        //Console.WriteLine();

        //numbers.Insert(0, 5);
        //foreach (int item in numbers)
        //{
        //    Console.Write($"{item} ");

        //}
        //Console.WriteLine();

        //bool b1 = numbers.Contains(50);
        //Console.WriteLine($" does 50 exists :{b1}");

        numbers.RemoveAll(i => i % 2 == 0);
        foreach (int item in numbers)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine(); // new line



        #endregion List
        #region Dictionary
        //Dictionary<int, string> students = new Dictionary<int, string>();
        //students.Add(1, "Vishal");
        //students.Add(2, "Pooja");
        //students.Add(3, "Babita");
        //students.Add(4, "Rekha");

        //Console.WriteLine($"Number of items : {students.Count}");

        //foreach (dynamic item in students)
        //{
        //    Console.WriteLine($" key :{item.Key} Value : {item.Value} ");
        //}
        //string name = students[2];
        //Console.WriteLine(name); // pooja

        //students[4] = "Akash";
        //name = students[4];
        //Console.WriteLine(name); // akash


        #endregion Dictionary

        #region stack
        //Stack<string> history = new Stack<string>();
        //history.Push("www.google.com");
        //history.Push("c# tutorial ");
        //history.Push("www.tutorialteachers.com");

        //Console.WriteLine($"Number of items :{history.Count}");
        //string i1 = history.Pop();
        //Console.WriteLine(i1);

        //Console.WriteLine($" Number of items : {history.Count}");

        //i1 = history.Pop();
        //Console.WriteLine(i1);
        //Console.WriteLine($" Number of items : {history.Count}");

        #endregion stack

        #region Quene
        Queue<string> name = new Queue<string>();
        name.Enqueue("Akash");
        name.Enqueue("Pooja");
        name.Enqueue("ujwal");

        Console.WriteLine($"Number of items :{name.Count}");

        string i2 = name.Dequeue();
        Console.WriteLine(i2);

        Console.WriteLine($" Number of items : {name.Count}");
        Console.WriteLine(); // new line

        #endregion Quene

        // method name hints 
        // if method name contains try, Default => it handels exception 
        // PeeK() -> it returns value without removing it 

        
        Console.ReadLine();

    }
    
}