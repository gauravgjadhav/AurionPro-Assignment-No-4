using System;
class TreyParseMethod
{
    public static void Main(string[] args)
    {
        bool res1;
        int a;
        string str = "12";
        res1 = int.TryParse(str, out a);
        Console.WriteLine("String is a numeric representation :" + res1);
    }
}
