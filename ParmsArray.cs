using System;
public class ParamArray
{
    public static void Main(string[] args)
    {
        UseParms(1, 2, 3, 4);
        UseParms(1, 'a');
        UseParms2();
        int[] myIntArray = { 5, 6, 7, 8, 9 };
        UseParms(myIntArray);

        Object[] myObjectArray = { 2,'b',"test","again" };
        UseParms2(myObjectArray);
        UseParms2(myIntArray);

    }

    public static void UseParms(params int[] list)
    {
        for(int i=0; i < list.Length; i++)
        {
            Console.Write(list[i]+"  ");
        }
        Console.WriteLine();
    }
    public static void UseParms2(params object[] list)
    {
        for(int i=0; i < list.Length; i++)
        {
            Console.Write(list[i]+" ");
        }
        Console.WriteLine();
    }

}