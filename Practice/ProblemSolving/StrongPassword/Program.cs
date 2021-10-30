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
     * Complete the 'minimumNumber' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. STRING password
     */

    public static int minimumNumber(int n, string password)
    {
        // Return the minimum number of characters to make the password strong
        string numbers = "0123456789";
        string lower_case = "abcdefghijklmnopqrstuvwxyz";
        string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string special_characters = "!@#$%^&*()-+";

        bool isNumbers = false;
        bool isLowerCase = false;
        bool isUpperCase = false;
        bool isSpecialCharacter = false;
        int count = 0;

        foreach (char element in password)
            if (numbers.Contains(element))
                isNumbers = true;
            else if (lower_case.Contains(element))
                isLowerCase = true;
            else if (upper_case.Contains(element))
                isUpperCase = true;
            else if (special_characters.Contains(element))
                isSpecialCharacter = true;
            else;

        if (!isNumbers)
            count++;
        if (!isLowerCase)
            count++;
        if (!isUpperCase)
            count++;
        if (!isSpecialCharacter)
            count++;

        if (6 - password.Length > count)
            return 6 - password.Length;
        else
            return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string password = Console.ReadLine();

        int answer = Result.minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
