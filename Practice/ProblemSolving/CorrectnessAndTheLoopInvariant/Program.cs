using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Solution
{
    public static void insertionSort(int[] A)
    {
        Array.Sort(A);
        foreach (int element in A)
            Console.Write(element + " ");
    }

    static void Main(string[] args)
    {
        Console.ReadLine();
        int[] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
        insertionSort(_ar);
    }
}

