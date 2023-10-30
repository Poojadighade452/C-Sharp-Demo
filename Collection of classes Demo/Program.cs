using System.Collections;


class program
{
    static void Main()
    {
        #region Arraylists

        //        ArrayList numbers = new ArrayList();
        //        numbers.Add(10);
        //        numbers.Add(20);
        //        numbers.Add(30);
        //        numbers.Add(40);

        //        foreach (int i in numbers)
        //        {
        //            Console.Write($"{i}  ");
        //        }
        //        // 10,20,30,40
        //        Console.WriteLine();

        //        numbers.Add(50); // it will add 40 at last in collection
        //        foreach (int i in numbers)
        //        {
        //            Console.Write($"{i} ");

        //        }
        //        // 10,20,30,40,50

        //        ICollection temp = new ArrayList() { 50, 60, 70 };
        //        numbers.AddRange(temp); // it will add all items form temp

        //        foreach (int i in numbers)
        //        {
        //            Console.Write($"{i} ");

        //        }

        //        Console.WriteLine();

        //        numbers.Insert(1, 15);
        //        foreach (int i in numbers)
        //        {
        //            Console.Write($"{i} ");
        //        }
        //        // 10,15,20,30,40,50,60,70

        //        ICollection temp1 = new ArrayList() { 11, 12, 13 };
        //        numbers.InsertRange(2, temp1);
        //        foreach (int i in numbers)
        //        {

        //            Console.Write($" {i} ");
        //        }
        //        // 10 ,11,12,13,15,20,30,40,50,60,70
        //        Console.WriteLine(); // new line
        //        Console.WriteLine($" Numbers of Items : {numbers.Count}"); //10


        //        numbers.Remove(12);
        //        foreach (int i in numbers)
        //        {
        //            Console.Write($" {i} ");
        //        }
        //        // 10,11,13,15,20,30,40,50,60,70



        //        Console.WriteLine(); // new line

        //        numbers.RemoveAt(2);
        //        foreach (int i in numbers)

        //        {
        //            Console.Write($" {i} ");
        //        }
        //        // 10,15,13,20,30,40,50,60,70
        //        Console.WriteLine();// new line

        //        numbers.RemoveRange(2, 3);
        //        foreach (int i in numbers)
        //        {
        //            Console.Write($" {i} ");
        //        }
        //        // 10, 15,40,50,60,70,

        //        Console.WriteLine();// new line 

        ////        bool b1 = numbers.Contains(55);
        ////        Console.WriteLine($" does  55 exists in collection : {b1} ");

        ////        bool b2 = numbers.Contains(60);
        ////        Console.WriteLine($" does  60 exists in collection : {b2} ");

        //Console.WriteLine();

        #endregion Arraylists

        #region Hashtable

        //        Hashtable students = new Hashtable();
        //        students.Add(1, "vishal");
        //        students.Add(2, "pooja");
        //        students.Add(3, " Hema");
        //        students.Add(4, "Babita");
        //    foreach (DictionaryEntry items in students)
        //        {
        //            Console.WriteLine($" key : {items.Key} values : {items.Value} ");
        //        }
        //        Console.WriteLine($" Numbers of Items : {students.Count} ");

        //        object v1 = students[2];
        //        Console.WriteLine(v1); //
        //                               // 
        //        if (students.ContainsKey(3))
        //        {
        //            Console.WriteLine($"key {3} already exists");
        //        }
        //        else
        //        {
        //            students.Add(3, "snehal");
        //        }


        //        foreach (DictionaryEntry item in students)
        //        {
        //            Console.WriteLine($"key : {item.Key} values : {item.Value} ");

        //        }
        #endregion Hashtable
        #region Stack 
        //Stack stack = new Stack();
        //stack.Push(10);
        //stack.Push(20);
        //stack.Push(30);

        //Console.WriteLine($" Number of items : {stack.Count}"); // 3 
        //object o1 = stack.Pop();
        //Console.WriteLine($" {o1} "); // 30 

        //Console.WriteLine($" Number of itesms : {stack.Count} "); // 2
        #endregion stack

        #region Queue

        Queue queue = new Queue();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);

        Console.WriteLine($"Number of items : {queue.Count}");

        object v1 = queue.Dequeue();
        Console.WriteLine(v1);// 10

        object v2 = queue.Dequeue();
        Console.WriteLine(v2);// 20

        object v3 = queue.Dequeue();
        Console.WriteLine(v3);// 30


        #endregion Queue

        Console.ReadLine();
    }
}
    
        

    


       
    

