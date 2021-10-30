﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'gemstones' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING_ARRAY arr as parameter.
     */

    public static int gemstones(List<string> arr)
    {
        var compare = new HashSet<char>(arr[0]);

        int sayac = 0;
        List<char> myGems = new List<char>();

        foreach (char element in compare)
        {
            sayac = 0;
            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i].Contains(element))
                {
                    sayac++;
                }
            }
            if (sayac == arr.Count - 1)
                myGems.Add(element);
        }
        return myGems.Count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> arr = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string arrItem = Console.ReadLine();
            arr.Add(arrItem);
        }

        int result = Result.gemstones(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
