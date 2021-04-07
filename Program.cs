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

class Solution
{
    // We say that a string contains the word hackerrank if a subsequence
    // of its characters spell the word hackerrank. Remeber that a
    // subsequence maintains the order of characters selected from a sequence.

    // More formally, let p[0],p[1],...,[p9] be the respective indices of
    // h, a, c, k, e, r, r, a, n, k in string s. If p[0]<p[1]<p[2]<...<p[9]
    // is true, then s contains hackerrank.

    // For each query, print YES on a new line if the string contains
    // hackerrank, otherwise, print NO.


    // Complete the hackerrankInString function below.
    static string hackerrankInString(string s)
    {
        const string expected = "hackerrank";
        int idx = 0;
        
        foreach(char c in expected)
        {
            bool found = false;
            for (; idx < s.Length && !found; idx++)
            {
                if (c == s[idx])
                    found = true;
            }

            if (!found)
                return "NO";
        }

        return "YES";
    }

    static void Main(string[] args)
    {
        string[] strings = new string[]
        {
            "hhaacckkekraraannk",
            "rhbaasdndfsdskgbfefdbrsdfhuyatrjtcrtyytktjjt"
        };

        foreach (string s in strings)
        {
            string result = hackerrankInString(s);

            Console.WriteLine(result);
        }
    }
}
