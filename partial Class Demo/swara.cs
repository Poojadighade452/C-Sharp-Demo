using System.Globalization;

partial class Student : IA

{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    partial void PrintS();

}
interface IA
{
    void Print();
}