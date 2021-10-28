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
     * Complete the 'funnyString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string funnyString(string s)
    {
        byte[] asciis = Encoding.ASCII.GetBytes(s);

        byte[] one = new byte[asciis.Length - 1];
        byte[] two = new byte[asciis.Length - 1];

        for (int i = 0; i < asciis.Length - 1; i++)
        {
            one[i] = Convert.ToByte(Math.Abs(asciis[i] - asciis[i + 1]));
        }

        Array.Reverse(asciis);
        for (int i = 0; i < asciis.Length - 1; i++)
        {
            two[i] = Convert.ToByte(Math.Abs(asciis[i] - asciis[i + 1]));
        }

        for (int i = 0; i < asciis.Length - 1; i++)
            if (one[i] != two[i])
                return "Not Funny";
        return "Funny";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            string result = Result.funnyString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
