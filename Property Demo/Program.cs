

class Program
{

 static void Main()
    {
        #region code1
        //  // setting values / asssigning values
        //  student s1 = new student();
        //  s1.RollNumber = 101;
        //  s1.Name = " Nehal";
        //  s1.PassMark = 40;

        ////  getting values / reaing values

        //  Console.WriteLine($" rollNumber : {s1.RollNumber} Name : {s1.Name} " +
        //      $", PassMark : {s1.PassMark}");
        #endregion code1


        //student s1 = new student();
        //s1.SetRollnumber(10);
        //s1.Name = " laila";
        //s1.PassMark = 65;


        //Console.WriteLine($" RollNumber : {s1.GetRollNumber} Name : {s1.Name} , passMark : {s1.PassMark} ");
        //student s2 = new student();
        //s2.SetRollnumber(20);
        //s2.SetName(" Mahesh");
        //s2.PassMark = 40;

        //Console.WriteLine($" rollNumber : {s2.GetRollNumber} , Name : {s2.GetName} , Passmark : {s2.PassMark}");

        student s3 = new student();
        s3.RollNumber = 10;
        s3.Name = " gumfa";
        s3.PassMark = 56;
        s3.city = " amravati";

        Console.WriteLine($" Rollnumber :{s3.RollNumber} , Name : {s3.Name}  , passmark : {s3.PassMark} city : {s3.city }");
        Console.ReadLine();
    }


}
class student
{
    private int _rollnumber;
     private string _Name;
    private int _passMark;
private string _city;

    //public int GetRollNumber()
    //{
    //    return _rollnumber;
    //}
    //public void SetRollnumber(int rn)
    //{
    //    if (rn > 0)
    //    {
    //        _rollnumber = rn;

    //    }
    //    else
    //    {
    //        Console.WriteLine($" cannot be  entred negative values ");
    //    }


    //}
    public int RollNumber
    {

        get
        {
            return -_rollnumber;

        }
        set
        {
            if ( value > 0)
            {
                _rollnumber = value;

            }
            else
            {
                Console.WriteLine($" RollNumber cannot be negative");
            }
        }
    }
    //public void SetName(string name)
    //{
    //    _Name = name;
    //}
    //public string GetName()
    //{
    //    return string.IsNullOrEmpty(_Name) ? " No Name" : _Name;


    //}




    public string Name
    {

        get
        {
            return string.IsNullOrEmpty(_Name) ? " No Name" : _Name;
        }
        set
        {
            _Name = value;
        }
    }
    public int PassMark
    {
        get
        {
            return _passMark;
        }
        set
        {
            _passMark = value;
        }
    }
    public string city
    {
        get
        {
            return _city;
        }
        set
        { _city = value; }
    } 

} 


