using System.CodeDom.Compiler;
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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        decimal negativeCount = 0, zeroCount = 0, positiveCount = 0;
        for (int i = 0; i < arr.Count; i++)
            if (arr[i] < 0)
                negativeCount++;
            else if (arr[i] == 0)
                zeroCount++;
            else
                positiveCount++;

        decimal negativePercent = negativeCount / arr.Count;
        decimal zeroPercent = zeroCount / arr.Count;
        decimal positivePercent = positiveCount / arr.Count;

        Console.WriteLine(string.Format("{0:0.######}", positivePercent));
        Console.WriteLine(string.Format("{0:0.######}", negativePercent));
        Console.WriteLine(string.Format("{0:0.######}", zeroPercent));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
