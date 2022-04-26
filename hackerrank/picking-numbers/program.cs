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
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {
        //Returns
        //int: the length of the longest subarray that meets the criterion
        //int difference = Math.Abs(a[i] - (j[i] + 1));
        
        List<int> numGroups = new List<int>();
        
        for (int i = 0; i < a.Count; i++)
        {
            int counter = 0;
            int counter2 = 0;
            
            //positive direction -> poss diff: 0 or 1
            for (int j = 0; j < a.Count; j++)
            {
                
                if (a[i] == a[j] || a[j] == a[i] + 1) // ==?
                {
                    counter++;
                }
                
            }
            
            numGroups.Add(counter);
            
            //negative direction -> poss diff: 0 or -1
            for (int k = 0; k < a.Count; k++)
            {
                
                if (a[i] == a[k] || a[i] == a[k] - 1)
                {
                    counter2++;
                }
                
            }
            
            numGroups.Add(counter2);
            
        }
        
        return numGroups.Max();
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
