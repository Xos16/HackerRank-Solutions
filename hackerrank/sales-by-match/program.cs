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
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        
        IDictionary<int, int> dictionary = new Dictionary<int, int>();
        
        for (int i = 0; i < ar.Count; i++)
        {
            int color = ar[i];
            
            if ( !(dictionary.ContainsKey(color)) )
            {
                dictionary.Add(color, 1);
            }
            
            else
            {
                int currentCount = dictionary[color];
                int newCount = currentCount + 1;
                dictionary.Remove(color);
                dictionary.Add(color, newCount);
            }
        }
           
           int pairCount = 0;
           dictionary.All(pair =>
           {
               pairCount += (pair.Value - (pair.Value % 2)) / 2;
               return true;
           });
           
           return pairCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
