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
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {    
              
        List<int> ResultGrades = new List<int>();
        
        foreach (int aGrade in grades)    
        {
            if (aGrade % 5 < 3 || aGrade < 38 )
            {
                //No Rounding
                ResultGrades.Add(aGrade);
            }     
            else
            {
            //Rounding
            ResultGrades.Add(aGrade + (5 - aGrade % 5));
            }                                
        }
        
         return ResultGrades;   
        
        
        
        
        //foreach (int element in fibNumbers)
        /*
        List<int> ResultGrades = new List<int>();                
        for (int i = 0; i < grades.Count; i++)
            {
                // no round up
                if (grades[i] % 5 < 3 || grades[i] < 38 )
                {
                    ResultGrades.Add(grades[i]);
                    //grades
                    //better container needed                     
                }            
                else
                {
                    ResultGrades.Add(grades[i] + (5 - grades[i] % 5));
                }                            
            }
            return ResultGrades;
            */        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
