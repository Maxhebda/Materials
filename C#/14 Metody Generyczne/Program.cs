using System;
using System.Collections;           //  <--- array list
using System.Collections.Generic;   //  <--- list

class Program
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
    static void Main(string[] args)
    {

        string a = "pierwszy";
        string b = "drugi";
        Swap(ref a, ref b);
        Console.WriteLine("a=" + a + ", b=" + b);

        int aa = 10;
        int bb = 20;
        Swap(ref aa, ref bb);
        Console.WriteLine("a=" + aa + ", b=" + bb);


        Console.ReadLine();
    }
}
