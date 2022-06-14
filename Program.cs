using System;
class InAndOutModifier
{
    public static void Main(string[] args)
    {
        int a = 44;
        InArrayExample(a);
        Console.WriteLine(a);

       // int a;
        OutArgExample(out a);
        Console.WriteLine(a);
    }
    static void InArrayExample(in int number)
    {
        //int number = 10;it give a error it is ReadOnly veriable
    }
    static void OutArgExample(out int number)
    {
        number = 10;
    }
}