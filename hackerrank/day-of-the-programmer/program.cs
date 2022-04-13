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
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {   
        bool LeapYearOrNot;
        int[] DaysOfMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31 };
        int DayOfProgrammers = 256;
        string ResultDate;
        
        if (year > 1918)
        
        {
            
            if (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0) )
        
            {
                LeapYearOrNot = true;
                DaysOfMonth[1] = 29;
            } 
            
            else
            {
                LeapYearOrNot = false;
            }
        
        }
        
        else if (year < 1918)
        
        {
            if (year % 4 == 0)
        
            {
                LeapYearOrNot = true;
                DaysOfMonth[1] = 29;
            } 
            
            else
            {
                LeapYearOrNot = false;
            }
        }
        
        else
        {
            return "26.09.1918";
        }
        
        int MonthSum = DaysOfMonth.Sum();
        
        DayOfProgrammers -= MonthSum;
        
        ResultDate = DayOfProgrammers + "." + "09" + "." + year;        
        
        return ResultDate;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
